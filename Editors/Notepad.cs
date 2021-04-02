using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TextEditor.Properties;
using Transitions;

namespace TextEditor.Editors
{
	public partial class Notepad : Form
	{
		public Notepad(EditorSelectionWindow selectionWindow)
		{
			InitializeComponent();

			this.selectionWindow = selectionWindow;

			Icon = Icon.FromHandle(Resources.notepadImage.GetHicon());

			Directory.CreateDirectory(Application.StartupPath + "\\Notes\\");

			string[] noteFiles = Directory.GetFiles(Application.StartupPath + "\\Notes\\");
			string[] names = new string[noteFiles.Length];
			
			for (int i = 0; i < noteFiles.Length; i++)
			{
				names[i] = Path.GetFileNameWithoutExtension(noteFiles[i]);
			}

			notes.Items.AddRange(names);
		}

		private EditorSelectionWindow selectionWindow;
		private int noteId = 1;
		private int activeNoteIndex = 0;

		private void Notepad_FormClosed(object sender, FormClosedEventArgs e)
		{
			selectionWindow.Visible = true;
		}

		private void NewNote(string noteTitle)
		{
			notes.Items.Add(noteTitle);
			editor.Enabled = true;
			editor.SaveFile(Application.StartupPath + "\\Notes\\" + noteTitle + ".rtf", RichTextBoxStreamType.RichText);
			editor.Enabled = false;
		}

		private void btnCreateNewNote_Click(object sender, EventArgs e)
		{
			NewNote(txtNoteTitle.Text);
		}
		private void btnDeleteSelectedNote_Click(object sender, EventArgs e)
		{
			notes.Items.RemoveAt(activeNoteIndex);
			File.Delete(Application.StartupPath + "\\Notes\\" + notes.Items[activeNoteIndex].ToString() + ".rtf");
			if (notes.Items.Count > 0) activeNoteIndex = 0;
			else if (notes.Items.Count < 1) activeNoteIndex = -1;
			editor.Enabled = false;
		}

		private void btnNewNote_Click(object sender, EventArgs e)
		{
			NewNote("New Note " + noteId);
			noteId++;
		}
		private void btnCutText_Click(object sender, EventArgs e)
		{
			editor.Cut();
		}
		private void btnCopyText_Click(object sender, EventArgs e)
		{
			editor.Copy();
		}
		private void btnPasteText_Click(object sender, EventArgs e)
		{
			editor.Paste();
		}
		private void btnRedoAction_Click(object sender, EventArgs e)
		{
			editor.Redo();
		}
		private void btnUndoAction_Click(object sender, EventArgs e)
		{
			editor.Undo();
		}

		private void ToggleFontStyle(out Font font, FontStyle fontStyle)
		{
			Font selectionFont = editor.SelectionFont;
			bool hasStyle = selectionFont.Style.HasFlag(fontStyle);
			FontStyle currentStyle = selectionFont.Style;

			if (hasStyle)
			{
				selectionFont = new Font(selectionFont, currentStyle & ~fontStyle);
			}
			else if (!hasStyle)
			{
				selectionFont = new Font(selectionFont, currentStyle | fontStyle);
			}

			font = selectionFont;
		}

		private void btnBoldText_Click(object sender, EventArgs e)
		{
			Font newFont = null;
			ToggleFontStyle(out newFont, FontStyle.Bold);
			editor.SelectionFont = newFont;
		}
		private void btnItalicText_Click(object sender, EventArgs e)
		{
			Font newFont = null;
			ToggleFontStyle(out newFont, FontStyle.Italic);
			editor.SelectionFont = newFont;
		}
		private void btnUnderlineText_Click(object sender, EventArgs e)
		{
			Font newFont = null;
			ToggleFontStyle(out newFont, FontStyle.Underline);
			editor.SelectionFont = newFont;
		}
		private void btnStrikethroughText_Click(object sender, EventArgs e)
		{
			Font newFont = null;
			ToggleFontStyle(out newFont, FontStyle.Strikeout);
			editor.SelectionFont = newFont;
		}
		private void notes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (notes.Items.Count > 0)
			{
				string noteFile = Application.StartupPath + "\\Notes\\" + notes.Items[activeNoteIndex].ToString() + ".rtf";

				editor.Enabled = true;
				editor.LoadFile(noteFile, RichTextBoxStreamType.RichText);
			}
			else if (notes.Items.Count < 1)
			{
				return;
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			switch (toolStripButton1.Text)
			{
				case "»":
					Transition transition1 = new Transition(new TransitionType_EaseInEaseOut(500));
					transition1.add(notes, "Width", 317);
					transition1.add(noteFormatMenu, "Width", Width - 317);
					transition1.add(noteFormatMenu, "Left", 317);
					transition1.add(editor, "Width", Width - 317);
					transition1.add(editor, "Left", 317);
					transition1.add(toolStripButton1, "Text", "«");
					transition1.run();
					break;
				case "«":
					Transition transition2 = new Transition(new TransitionType_EaseInEaseOut(500));
					transition2.add(notes, "Width", 0);
					transition2.add(noteFormatMenu, "Width", Width);
					transition2.add(noteFormatMenu, "Left", 0);
					transition2.add(editor, "Width", Width);
					transition2.add(editor, "Left", 0);
					transition2.add(toolStripButton1, "Text", "»");
					transition2.run();
					break;
			}
		}
		private void btnSaveNote_Click(object sender, EventArgs e)
		{
			string noteFile = Application.StartupPath + "\\Notes\\" + notes.Items[activeNoteIndex].ToString() + ".rtf";

			editor.SaveFile(noteFile, RichTextBoxStreamType.RichText);
		}
	}
}
