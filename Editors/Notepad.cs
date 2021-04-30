using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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

			ListNotes();

			#region Random String Generation

			for (int z = 0; z < 500; z++)
			{
				Random rnd = new Random();
				string randomNoteName = string.Empty;
				const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
				randomNoteName = new string(Enumerable.Repeat(chars, 32).Select(s => s[rnd.Next(s.Length)]).ToArray());
				randomNoteNames.Add(randomNoteName);
			}

			#endregion
		}

		private EditorSelectionWindow selectionWindow;
		private readonly string baseNotePath = Application.StartupPath + "\\Notes";
		private List<string> randomNoteNames = new List<string>();
		private string currentNote = string.Empty;

		private void Notepad_FormClosed(object sender, FormClosedEventArgs e)
		{
			selectionWindow.Visible = true;
		}

		private string RandomNoteName()
		{
			return randomNoteNames[new Random().Next(-1, randomNoteNames.Count + 1)];
		}

		private void ListDirectory(TreeView treeView, string path)
		{
			treeView.Nodes.Clear();

			Stack<TreeNode> stack = new Stack<TreeNode>();
			DirectoryInfo rootDirectory = new DirectoryInfo(path);
			TreeNode node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
			stack.Push(node);

			while (stack.Count > 0)
			{
				TreeNode currentNode = stack.Pop();
				DirectoryInfo directoryInfo = (DirectoryInfo)currentNode.Tag;
				foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
				{
					TreeNode childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
					currentNode.Nodes.Add(childDirectoryNode);
					stack.Push(childDirectoryNode);
				}
				foreach (FileInfo file in directoryInfo.GetFiles())
					currentNode.Nodes.Add(new TreeNode(file.Name));
			}

			treeView.Nodes.Add(node);
		}
		private TreeNode GetCurrentNode()
		{
			return notes.SelectedNode;
		}
		private void ListNotes()
		{
			ListDirectory(notes, baseNotePath);
		}
		private void NewNote(string noteTitle, bool openEditor = false)
		{
			editor.Enabled = true;
			editor.Text = string.Empty;
			editor.Enabled = false;
			File.Create(baseNotePath + "\\" + noteTitle + ".rtf").Close();
			editor.Enabled = true;
			editor.SaveFile(baseNotePath + "\\" + noteTitle + ".rtf", RichTextBoxStreamType.RichText);
			editor.Enabled = false;
			if (openEditor)
			{
				editor.Enabled = true;
				editor.LoadFile(baseNotePath + "\\" + noteTitle + ".rtf", RichTextBoxStreamType.RichText);
			}
			ListNotes();
		}
		private void btnCreateNewNote_Click(object sender, EventArgs e)
		{
			NewNote(txtNoteTitle.Text, false);
		}
		private void btnNewNote_Click(object sender, EventArgs e)
		{
			NewNote(RandomNoteName(), false);
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
			editor.SaveFile(currentNote, RichTextBoxStreamType.RichText);
			editor.Text = string.Empty;
			editor.Enabled = false;
		}
		private void SelectNote()
		{
			if (GetCurrentNode().Text.Contains(".rtf"))
			{
				currentNote = baseNotePath + "\\" + GetCurrentNode().Text;
				editor.Enabled = true;
				editor.LoadFile(currentNote, RichTextBoxStreamType.RichText);
				deleteCurrentNote.Enabled = true;
				toolStripSeparator2.Visible = true;
				deleteCurrentNote.Visible = true;
			}
			else
			{
				editor.Text = string.Empty;
				editor.Enabled = false;
				deleteCurrentNote.Enabled = false;
			}
		}
		private void notes_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)(Keys.Enter | Keys.Return))
			{
				SelectNote();
			}
		}
		private void deleteCurrentNote_Click(object sender, EventArgs e)
		{
			if (GetCurrentNode().Text == Path.GetFileName(currentNote))
			{
				GetCurrentNode().Remove();
				File.Delete(currentNote);

				deleteCurrentNote.Enabled = false;

				toolStripSeparator2.Visible = false;
				deleteCurrentNote.Visible = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("" +
				"- The buttons at the top with the 'paper' icons and the 'A' icons are used for basic text editing.\n\n" +
				"- Click the double-arrow button on the far left side of the menu strip at the top to toggle the 'notes menu'.\n\n" +
				"- Use the arrow keys on your keyboard to navigate the TreeView.\n\n" +
				"- Use up-arrow and down-arrow to go up down on the whole list.\n\n" +
				"- Use the left-arrow to close a list, and the right-arrow to open a list.\n\n" +
				"- Use 'Enter' or 'Return' on your keyboard to select a note to open it.\n\n" +
				"- Use the 'Save Note' button to save your changes.\n\n" +
				"- Creating a folder inside the 'Notes' folder will not allow you to access those notes in the new folder.\n\n" +
				"- All notes are created and accessed in only the 'Notes' folder, any other folders added and containing other notes will render those new notes 'inaccessible'.", "How To Use the NOTEPAD", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
