using AMS.Profile;
using FastColoredTextBoxNS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
					editor_WordWrap ? "Active" : "Inactive");

				currentLanguage.Text = string.Format("{0}", advancedEditor.Language);

				if (showMenuItemsChecked)
				{
					editorWordWrap.Checked = editor_WordWrap;
					btnlangCustom.Checked = lang_Custom;
					btnlangCSharp.Checked = lang_CSharp;
					btnlangVisualBasic.Checked = lang_VisualBasic;
					btnlangHTML.Checked = lang_HTML;
					btnlangXML.Checked = lang_XML;
					btnlangSQL.Checked = lang_SQL;
					btnlangPHP.Checked = lang_PHP;
					btnlangJS.Checked = lang_JS;
					btnlangLua.Checked = lang_Lua;
				}
				else if (!showMenuItemsChecked)
				{
					editorWordWrap.Checked = false;
					btnlangCustom.Checked = false;
					btnlangCSharp.Checked = false;
					btnlangVisualBasic.Checked = false;
					btnlangHTML.Checked = false;
					btnlangXML.Checked = false;
					btnlangSQL.Checked = false;
					btnlangPHP.Checked = false;
					btnlangJS.Checked = false;
					btnlangLua.Checked = false;
				}
			};
			t.Start();

			Icon = Resources.codeIcon;

			ini = new Ini(ConfigFile.Path);
			LoadSettings();
		}

		private Ini ini;
		private EditorSelectionWindow selectionWindow;
		private const string ce = "CodeEditor";

		private void SaveSettings()
		{
			// now to save the settings if the user changed them
			ini.SetValue(ce, "WordWrap", editor_WordWrap.ToString().ToLower());
			ini.SetValue(ce, "CurrentLanguage", advancedEditor.Language.ToString());
			ini.SetValue(ce, "FontName", advancedEditor.Font.Name);
			ini.SetValue(ce, "FontSize", advancedEditor.Font.Size.ToString());
			ini.SetValue(ce, "ShowMenuItemsChecked", showMenuItemsChecked.ToString().ToLower());
		}
		private void LoadSettings()
		{
			// now to load all of the settings for the code editor
			editor_WordWrap = Convert.ToBoolean(ini.GetValue(ce, "WordWrap"));
			advancedEditor.Language = (Language)TypeDescriptor.GetConverter(typeof(Language))
				.ConvertFromString(ini.GetValue(ce, "CurrentLanguage").ToString());
			advancedEditor.Font = new Font(
				ini.GetValue(ce, "FontName").ToString(),
				Convert.ToSingle(ini.GetValue(ce, "FontSize").ToString())
				);
			showMenuItemsChecked = Convert.ToBoolean(ini.GetValue(ce, "ShowMenuItemsChecked").ToString());

			advancedEditor.WordWrap = editor_WordWrap;
			btnShowMnuItmChecked.Text = "Show Menu Items Checked: " + (showMenuItemsChecked ? "ON" : "OFF");
		}

		private void CodeEditor_FormClosed(object sender, FormClosedEventArgs e)
		{
			selectionWindow.Visible = true;
		}

		private string selectedFile = string.Empty;
		private StreamReader fileReader;
		private StreamWriter fileWriter;

		private bool showMenuItemsChecked = true;
		private bool
			editor_WordWrap = false;
		private bool
			lang_Custom = true,
			lang_CSharp = false,
			lang_VisualBasic = false,
			lang_HTML = false,
			lang_XML = false,
			lang_SQL = false,
			lang_PHP = false,
			lang_JS = false,
			lang_Lua = false;

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
			if (selectedFile == string.Empty)
			{
				if (advancedEditor.Text == string.Empty)
				{
					resetEditor();
				}
				else if (advancedEditor.Text != string.Empty)
				{
					DialogResult userChoice = MessageBox.Show("Are you sure you'd like to start a new file without saving your changes?", "Start Anew Without Saving?",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (userChoice == DialogResult.Yes)
					{
						resetEditor();
					}
					else if (userChoice == DialogResult.No)
					{
						saveFileAs_Click(sender, e);
					}
				}
			}
			else
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

			SaveSettings();
		}
		private void editorFontFamily_Click(object sender, EventArgs e)
		{
			new FontNameEditor(null, null, advancedEditor).ShowDialog();

			SaveSettings();
		}

		// format menu
		private void editorWordWrap_Click(object sender, EventArgs e)
		{
			editor_WordWrap = !editor_WordWrap;
			advancedEditor.WordWrap = editor_WordWrap;

			SaveSettings();
		}

		// menu button without children on dropdown
		private void btnShowMnuItmChecked_Click(object sender, EventArgs e)
		{
			switch (btnShowMnuItmChecked.Text)
			{
				case "Show Menu Items Checked: ON":
					btnShowMnuItmChecked.Text = "Show Menu Items Checked: OFF";
					btnShowMnuItmChecked.Checked = false;
					showMenuItemsChecked = false;
					break;
				case "Show Menu Items Checked: OFF":
					btnShowMnuItmChecked.Text = "Show Menu Items Checked: ON";
					btnShowMnuItmChecked.Checked = true;
					showMenuItemsChecked = true;
					break;
			}

			SaveSettings();
		}

		// menu at bottom of window
		private void btnlangCustom_Click(object sender, EventArgs e)
		{
			lang_Custom = !lang_Custom;

			lang_Custom = true;
			lang_CSharp = false;
			lang_VisualBasic = false;
			lang_HTML = false;
			lang_XML = false;
			lang_SQL = false;
			lang_PHP = false;
			lang_JS = false;
			lang_Lua = false;

			advancedEditor.Language = Language.Custom;

			SaveSettings();
		}
		private void btnlangCSharp_Click(object sender, EventArgs e)
		{
			lang_CSharp = !lang_CSharp;

			lang_Custom = false;
			lang_CSharp = true;
			lang_VisualBasic = false;
			lang_HTML = false;
			lang_XML = false;
			lang_SQL = false;
			lang_PHP = false;
			lang_JS = false;
			lang_Lua = false;

			advancedEditor.Language = Language.CSharp;

			SaveSettings();
		}
		private void btnlangVisualBasic_Click(object sender, EventArgs e)
		{
			lang_VisualBasic = !lang_VisualBasic;

			lang_Custom = false;
			lang_CSharp = false;
			lang_VisualBasic = true;
			lang_HTML = false;
			lang_XML = false;
			lang_SQL = false;
			lang_PHP = false;
			lang_JS = false;
			lang_Lua = false;

			advancedEditor.Language = Language.VB;

			SaveSettings();
		}
		private void btnlangHTML_Click(object sender, EventArgs e)
		{
			lang_HTML = !lang_HTML;

			lang_Custom = false;
			lang_CSharp = false;
			lang_VisualBasic = false;
			lang_HTML = true;
			lang_XML = false;
			lang_SQL = false;
			lang_PHP = false;
			lang_JS = false;
			lang_Lua = false;

			advancedEditor.Language = Language.HTML;

			SaveSettings();
		}
		private void btnlangXML_Click(object sender, EventArgs e)
		{
			lang_XML = !lang_XML;

			lang_Custom = false;
			lang_CSharp = false;
			lang_VisualBasic = false;
			lang_HTML = false;
			lang_XML = true;
			lang_SQL = false;
			lang_PHP = false;
			lang_JS = false;
			lang_Lua = false;

			advancedEditor.Language = Language.XML;

			SaveSettings();
		}
		private void btnlangSQL_Click(object sender, EventArgs e)
		{
			lang_SQL = !lang_SQL;

			lang_Custom = false;
			lang_CSharp = false;
			lang_VisualBasic = false;
			lang_HTML = false;
			lang_XML = false;
			lang_SQL = true;
			lang_PHP = false;
			lang_JS = false;
			lang_Lua = false;

			advancedEditor.Language = Language.SQL;

			SaveSettings();
		}
		private void btnlangPHP_Click(object sender, EventArgs e)
		{
			lang_PHP = !lang_PHP;

			lang_Custom = false;
			lang_CSharp = false;
			lang_VisualBasic = false;
			lang_HTML = false;
			lang_XML = false;
			lang_SQL = false;
			lang_PHP = true;
			lang_JS = false;
			lang_Lua = false;

			advancedEditor.Language = Language.PHP;

			SaveSettings();
		}
		private void btnlangJS_Click(object sender, EventArgs e)
		{
			lang_JS = !lang_JS;

			lang_Custom = false;
			lang_CSharp = false;
			lang_VisualBasic = false;
			lang_HTML = false;
			lang_XML = false;
			lang_SQL = false;
			lang_PHP = false;
			lang_JS = true;
			lang_Lua = false;

			advancedEditor.Language = Language.JS;

			SaveSettings();
		}
		private void btnlangLua_Click(object sender, EventArgs e)
		{
			lang_JS = !lang_JS;

			lang_Custom = false;
			lang_CSharp = false;
			lang_VisualBasic = false;
			lang_HTML = false;
			lang_XML = false;
			lang_SQL = false;
			lang_PHP = false;
			lang_JS = false;
			lang_Lua = true;

			advancedEditor.Language = Language.Lua;

			SaveSettings();
		}
	}
}
