using DropShadow;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using TextEditor.Editors;
using Transitions;

namespace TextEditor
{
	public partial class EditorSelectionWindow : Form
	{
		public EditorSelectionWindow()
		{
			InitializeComponent();

			DropShadowCS dropShadow = new DropShadowCS();
			dropShadow.CreateDropShadow(this, new Control[]
				{
					this,
					windowTitle,
				});
			dropShadow.CreateWNDParams(CreateParams);

			CheckForUpdates(this);
		}

		private void closeWindowSelection_MouseEnter(object sender, EventArgs e)
		{
			Transition.run(closeWindowSelection, "ForeColor",
				Color.FromArgb(
					70, 70, 243
					), new TransitionType_Linear(100));
		}
		private void closeWindowSelection_MouseLeave(object sender, EventArgs e)
		{
			Transition.run(closeWindowSelection, "ForeColor",
				Color.FromArgb(
					243, 70, 70
					), new TransitionType_Linear(100));
		}
		private void closeWindowSelection_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void editorSelection_FadeHover(object sender, EventArgs e)
		{
			Transition.run(sender, "BackColor", SystemColors.ControlLight,
				new TransitionType_Linear(100));
		}
		private void editorSelection_FadeLeave(object sender, EventArgs e)
		{
			Transition.run(sender, "BackColor", SystemColors.Control,
				new TransitionType_Linear(100));
		}

		private void useTextEditor_Click(object sender, EventArgs e)
		{
			Visible = false;
			new Editors.TextEditor(this).Show();

			ModifyCANCELButton();
		}
		private void useCodeEditor_Click(object sender, EventArgs e)
		{
			Visible = false;
			new CodeEditor(this).Show();

			ModifyCANCELButton();
		}
		private void useNotepad_Click(object sender, EventArgs e)
		{
			Visible = false;
			new Notepad(this).Show();

			ModifyCANCELButton();
		}

		private void ModifyCANCELButton()
		{
			closeWindowSelection.Text = "CLOSE";
			closeWindowSelection.Location = new Point(239, 240);
		}

		private void checkForUpdates_Click(object sender, EventArgs e)
		{
			CheckForUpdates(sender);
		}

		private void CheckForUpdates(object sender)
		{
			WebClient webClient = new WebClient();

			try
			{
				Assembly appAssembly = Assembly.GetExecutingAssembly();
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(appAssembly.Location);
				string currentVersion = string.Format("{0}.{1}.{2}",
					appAssembly.GetName().Version.Major,
					appAssembly.GetName().Version.Minor,
					versionInfo.FileBuildPart);
				string otherVersion = webClient.DownloadString("https://pastebin.com/raw/bXvC8dDZ").Substring(12, 5);

				if (currentVersion != otherVersion)
				{
					DialogResult question = MessageBox.Show("Update found! Would you like to download it?\n\n" +
						"Do note: This will download the installer since that's the laziest way I can come up with for downloading an update.", "Update Found!",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (question == DialogResult.Yes)
					{
						MessageBox.Show("Current Version: " + currentVersion + "\n\n" + webClient.DownloadString("https://pastebin.com/raw/bXvC8dDZ"), "Update Information",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						DownloadUpdate();
					}
					else if (question == DialogResult.No)
					{
						MessageBox.Show("Just remember, you can always download the update another time.", "Message",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else if (currentVersion == otherVersion)
				{
					if (sender == checkForUpdates)
					{
						MessageBox.Show("No updates found. You're on the latest version!", "Latest Version",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (sender == this)
					{
						return;
					}
				}
			}
			catch (Exception exc)
			{
				if (sender == checkForUpdates)
				{
					MessageBox.Show(exc.Message);
					MessageBox.Show("Couldn't get version information for update check.\n\n" +
						"Updates require checking online for changes, so please make sure you are connected to the internet. If it's not that, then it could just be an error in the program.\n\n" +
						"Please contact sh4d0w4rch3r415@gmail.com for any issues with the update.", "Failed To Get Version Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (sender == this)
				{
					return;
				}
			}
		}

		private void DownloadUpdate()
		{
			WebClient webClient = new WebClient();

			try
			{
				Thread.Sleep(2500);

				string otherVersion = webClient.DownloadString("https://pastebin.com/raw/bXvC8dDZ");

				string zipPath = string.Empty;
				using (SaveFileDialog sfd = new SaveFileDialog
				{
					Title = "Please select the folder where you will be downloading the installer...",
					FileName = otherVersion.Substring(12, 3) + ".zip",
					Filter = "ZIP File|*.zip",
					FilterIndex = 0,
				})
				{
					if (sfd.ShowDialog() == DialogResult.OK)
					{
						webClient.DownloadFile("https://app-download.000webhostapp.com/Downloads/" + otherVersion.Substring(12, 3) + "-OnlineUpdates.zip", sfd.FileName);
						zipPath = sfd.FileName;
					}
				}

				string userName = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
				string extractPath = "C:\\Users\\" + userName + "\\Desktop\\";
				Directory.CreateDirectory(extractPath + "\\TextEditor " + otherVersion + "-OnlineUpdates");
				ZipFile.ExtractToDirectory(zipPath, extractPath + "\\TextEditor " + otherVersion + "-OnlineUpdates");

				DialogResult question = MessageBox.Show("Run installer now or do it later on your own time?\n\n" +
					"[Yes: Now] - [No: On My Own Time]", "Install Now or Later", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (question == DialogResult.Yes)
				{
					Process.Start(extractPath + "\\TextEditor " + otherVersion + "-OnlineUpdates\\Install-TextEditor.exe");
				}
				else if (question == DialogResult.No)
				{
					return;
				}
			}
			catch
			{
				MessageBox.Show("Failed to download update. Please try again later.", "Update Failed To Download",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void checkForUpdates_MouseEnter(object sender, EventArgs e)
		{
			Transition.run(checkForUpdates, "ForeColor", Color.FromArgb(70, 200, 125), new TransitionType_Linear(100));
		}
		private void checkForUpdates_MouseLeave(object sender, EventArgs e)
		{
			Transition.run(checkForUpdates, "ForeColor", Color.FromArgb(150, 150, 70), new TransitionType_Linear(100));
		}
	}
}
