
namespace TextEditor
{
	partial class EditorSelectionWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorSelectionWindow));
			this.windowTitle = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.useNotepad = new System.Windows.Forms.PictureBox();
			this.useCodeEditor = new System.Windows.Forms.PictureBox();
			this.useTextEditor = new System.Windows.Forms.PictureBox();
			this.closeWindowSelection = new System.Windows.Forms.Label();
			this.helpInfo = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.useNotepad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.useCodeEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.useTextEditor)).BeginInit();
			this.SuspendLayout();
			// 
			// windowTitle
			// 
			this.windowTitle.AutoSize = true;
			this.windowTitle.Font = new System.Drawing.Font("Roboto", 24F);
			this.windowTitle.Location = new System.Drawing.Point(114, 39);
			this.windowTitle.Name = "windowTitle";
			this.windowTitle.Size = new System.Drawing.Size(317, 38);
			this.windowTitle.TabIndex = 0;
			this.windowTitle.Text = "TextEditor - Selection";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.useNotepad, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.useCodeEditor, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.useTextEditor, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 104);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 70);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// useNotepad
			// 
			this.useNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.useNotepad.Image = global::TextEditor.Properties.Resources.notepadImage;
			this.useNotepad.Location = new System.Drawing.Point(233, 3);
			this.useNotepad.Name = "useNotepad";
			this.useNotepad.Size = new System.Drawing.Size(109, 64);
			this.useNotepad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.useNotepad.TabIndex = 2;
			this.useNotepad.TabStop = false;
			this.helpInfo.SetToolTip(this.useNotepad, "Use the notepad for just taking notes.");
			this.useNotepad.MouseEnter += new System.EventHandler(this.editorSelection_FadeHover);
			this.useNotepad.MouseLeave += new System.EventHandler(this.editorSelection_FadeLeave);
			// 
			// useCodeEditor
			// 
			this.useCodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.useCodeEditor.Image = global::TextEditor.Properties.Resources.codeImage;
			this.useCodeEditor.Location = new System.Drawing.Point(118, 3);
			this.useCodeEditor.Name = "useCodeEditor";
			this.useCodeEditor.Size = new System.Drawing.Size(109, 64);
			this.useCodeEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.useCodeEditor.TabIndex = 1;
			this.useCodeEditor.TabStop = false;
			this.helpInfo.SetToolTip(this.useCodeEditor, "Use the code editor to edit advanced text and strings.");
			this.useCodeEditor.MouseEnter += new System.EventHandler(this.editorSelection_FadeHover);
			this.useCodeEditor.MouseLeave += new System.EventHandler(this.editorSelection_FadeLeave);
			// 
			// useTextEditor
			// 
			this.useTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.useTextEditor.Image = global::TextEditor.Properties.Resources.textImage;
			this.useTextEditor.Location = new System.Drawing.Point(3, 3);
			this.useTextEditor.Name = "useTextEditor";
			this.useTextEditor.Size = new System.Drawing.Size(109, 64);
			this.useTextEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.useTextEditor.TabIndex = 0;
			this.useTextEditor.TabStop = false;
			this.helpInfo.SetToolTip(this.useTextEditor, "Use the text editor to edit basic text and strings.");
			this.useTextEditor.Click += new System.EventHandler(this.useTextEditor_Click);
			this.useTextEditor.MouseEnter += new System.EventHandler(this.editorSelection_FadeHover);
			this.useTextEditor.MouseLeave += new System.EventHandler(this.editorSelection_FadeLeave);
			// 
			// closeWindowSelection
			// 
			this.closeWindowSelection.AutoSize = true;
			this.closeWindowSelection.Font = new System.Drawing.Font("Webdings", 14F);
			this.closeWindowSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.closeWindowSelection.Location = new System.Drawing.Point(259, 194);
			this.closeWindowSelection.Name = "closeWindowSelection";
			this.closeWindowSelection.Size = new System.Drawing.Size(29, 24);
			this.closeWindowSelection.TabIndex = 2;
			this.closeWindowSelection.Text = "r";
			this.helpInfo.SetToolTip(this.closeWindowSelection, "Close the application and the selector.");
			this.closeWindowSelection.Click += new System.EventHandler(this.closeWindowSelection_Click);
			this.closeWindowSelection.MouseEnter += new System.EventHandler(this.closeWindowSelection_MouseEnter);
			this.closeWindowSelection.MouseLeave += new System.EventHandler(this.closeWindowSelection_MouseLeave);
			// 
			// EditorSelectionWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(544, 235);
			this.Controls.Add(this.closeWindowSelection);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.windowTitle);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Roboto", 14F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditorSelectionWindow";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TextEditor";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.useNotepad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.useCodeEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.useTextEditor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label windowTitle;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox useNotepad;
		private System.Windows.Forms.PictureBox useCodeEditor;
		private System.Windows.Forms.PictureBox useTextEditor;
		private System.Windows.Forms.Label closeWindowSelection;
		private System.Windows.Forms.ToolTip helpInfo;
	}
}

