using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TextEditor.Properties;
using TextEditor.PropertyEditors;

namespace TextEditor.Editors
{
	public partial class CodeEditor : Form
	{
		public CodeEditor(EditorSelectionWindow selectionWindow)
		{
			InitializeComponent();

			this.selectionWindow = selectionWindow;

			Timer t = new Timer { Interval = 1 };
			t.Tick += (sender, e) =>
			{
				if (selectedFile == string.Empty)
					Text = "CodeEditor - No File Selected";
				else if (selectedFile != string.Empty)
					Text = "CodeEditor - File: " + selectedFile;

				currentFont.Text = string.Format("{0}, {1}pt",
					advancedEditor.Font.Name,
					advancedEditor.Font.Size);

				currentWordWrap.Text = string.Format("WordWrap: {0}",
					editorWordWrap.Checked ? "Active" : "Inactive");

				currentLanguage.Text = string.Format("{0}", advancedEditor.Language);
			};
			t.Start();

			Icon = Resources.codeIcon;
		}

		private EditorSelectionWindow selectionWindow;

		private void CodeEditor_FormClosed(object sender, FormClosedEventArgs e)
		{
			selectionWindow.Visible = true;
		}

		private string selectedFile = string.Empty;
		private StreamReader fileReader;
		private StreamWriter fileWriter;

		// file menu
		private void openFile_Click(object sender, EventArgs e)
		{
			// create a disposable using statement for opening files
			using (OpenFileDialog ofd = new OpenFileDialog
			{
				Title = "Please select a file to open...",
				Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
				FilterIndex = 0,
			})
			{
				// check to see if the user confirmed the selected file in the dialog
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					// get name, extension, and directory of the selected file
					selectedFile = ofd.FileName;

					// create a disposable using statement for a StreamReader to get the file's contents as a string
					using (fileReader = new StreamReader(selectedFile))
					{
						// copy the contents of the file as a string and put it into the editor
						advancedEditor.Text = fileReader.ReadToEnd();
						fileReader.Close();
					}
				}
			}
		}
		private void saveFile_Click(object sender, EventArgs e)
		{
			// get the value of the opened file and any unsaved changes
			string currentFile = string.Empty;
			string changes = string.Empty;
			if (selectedFile != string.Empty)
			{
				using (fileReader = new StreamReader(selectedFile))
				{
					currentFile = fileReader.ReadToEnd();
					fileReader.Close();
				}
			}
			changes = advancedEditor.Text;

			// compare the strings and see if there are any changes, even if there's only 1
			if (currentFile == changes)
				MessageBox.Show("No changes were made to the file.", "No Changes Made",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			else if (currentFile != changes)
			{
				// ask the user if they'd like to confirm these changes
				DialogResult userChoice = MessageBox.Show("Are you sure you'd like to confirm/save these changes?",
					"Confirm/Save the Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (userChoice == DialogResult.Yes)
				{
					// write and save the changes to the file
					using (fileWriter = new StreamWriter(selectedFile))
					{
						fileWriter.Write(changes);
						fileWriter.Close();
					}
				}
				else if (userChoice == DialogResult.No)
				{
					// don't write or save the changes to the file
					return;
				}
			}
		}
		private void saveFileAs_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog sfd = new SaveFileDialog
			{
				Title = "Please choose a name and location for the new file...",
				Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
				FilterIndex = 0,
			})
			{
				// check to see if the user confirmed the new file and the contents to be written to it
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					// get the name, extension, and directory of the selected file
					selectedFile = sfd.FileName;

					// create a disposable using statement for a StreamWriter to write the new file's contents from a string
					using (fileWriter = new StreamWriter(selectedFile))
					{
						// check to see which editor the user is using
						fileWriter.Write(advancedEditor.Text);
						fileWriter.Close();
					}
				}
			}
		}
		private void newFile_Click(object sender, EventArgs e)
		{
			using (fileReader = new StreamReader(selectedFile))
			{
				bool condition = advancedEditor.Text == fileReader.ReadToEnd();

				if (condition)
				{
					resetEditor();
				}
				else if (!condition)
				{
					DialogResult userChoice1 = MessageBox.Show("Are you sure you'd like to start/create a new file without saving these changes?", "Continue Without Saving?",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					switch (userChoice1)
					{
						case DialogResult.Yes:
							resetEditor();
							break;
						case DialogResult.No:
							DialogResult userChoice2 = MessageBox.Show("Would you like to save the changes or save them to a new file?", "Save To Current or Make New File?",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question);

							switch (userChoice2)
							{
								case DialogResult.Yes:
									using (fileWriter = new StreamWriter(selectedFile))
									{
										fileWriter.Write(advancedEditor.Text);
										fileWriter.Close();
									}
									break;
								case DialogResult.No:
									using (SaveFileDialog sfd = new SaveFileDialog
									{
										Title = "Please choose the location and name for your new file...",
										Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
										FilterIndex = 0,
									})
									{
										if (sfd.ShowDialog() == DialogResult.OK)
										{
											using (fileWriter = new StreamWriter(selectedFile))
											{
												fileWriter.Write(advancedEditor.Text);
												fileWriter.Close();
											}
										}
									}
									break;
							}
							break;
					}
				}
			}
		}
		private void viewFile_Click(object sender, EventArgs e)
		{
			// open the selected file in File Explorer
			if (selectedFile == string.Empty)
			{
				MessageBox.Show("There is no file to view in the File Explorer.\n" +
					"Please open a file or make and save one to view it.", "No File Selected",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Process.Start("explorer.exe", Path.GetDirectoryName(selectedFile));
			}
		}

		private void resetEditor()
		{
			selectedFile = string.Empty;
			advancedEditor.Text = "";
			Width++;
			Width--;
			Invalidate();
		}

		// edit menu
		private void cutText_Click(object sender, EventArgs e)
		{
			advancedEditor.Cut();
		}
		private void copyText_Click(object sender, EventArgs e)
		{
			advancedEditor.Copy();
		}
		private void pasteText_Click(object sender, EventArgs e)
		{
			advancedEditor.Paste();
		}
		private void undoAction_Click(object sender, EventArgs e)
		{
			advancedEditor.Undo();
		}
		private void redoAction_Click(object sender, EventArgs e)
		{
			advancedEditor.Redo();
		}

		// format menu -> font
		private void editorFontSize_Click(object sender, EventArgs e)
		{
			new FontSizeEditor(null, null, advancedEditor).ShowDialog();
		}
		private void editorFontFamily_Click(object sender, EventArgs e)
		{
			new FontNameEditor(null, null, advancedEditor).ShowDialog();
		}

		// format menu
		private void editorWordWrap_Click(object sender, EventArgs e)
		{
			advancedEditor.WordWrap = editorWordWrap.Checked;
		}
	}
}
