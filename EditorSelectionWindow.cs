using DropShadow;
using System;
using System.Drawing;
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

			closeWindowSelection.Text = "CLOSE";
			closeWindowSelection.Location = new Point(239, 194);
		}
		private void useCodeEditor_Click(object sender, EventArgs e)
		{
			Visible = false;
			new CodeEditor(this).Show();

			closeWindowSelection.Text = "CLOSE";
			closeWindowSelection.Location = new Point(239, 194);
		}
		private void useNotepad_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Unfortunately this editor type has not been developed. I am currently working on it any chance I get/have, and will release it with the application ASAP.", "Editor Not Released and Coming Soon",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
