
namespace TextEditor.Editors
{
	partial class Notepad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
			this.noteFormatMenu = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnNewNote = new System.Windows.Forms.ToolStripButton();
			this.btnSaveNote = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnCutText = new System.Windows.Forms.ToolStripButton();
			this.btnCopyText = new System.Windows.Forms.ToolStripButton();
			this.btnPasteText = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRedoAction = new System.Windows.Forms.ToolStripButton();
			this.btnUndoAction = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnBoldText = new System.Windows.Forms.ToolStripButton();
			this.btnItalicText = new System.Windows.Forms.ToolStripButton();
			this.btnUnderlineText = new System.Windows.Forms.ToolStripButton();
			this.btnStrikethroughText = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteCurrentNote = new System.Windows.Forms.ToolStripButton();
			this.editor = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuNewNote = new System.Windows.Forms.ToolStripMenuItem();
			this.txtNoteTitle = new System.Windows.Forms.ToolStripTextBox();
			this.btnCreateNewNote = new System.Windows.Forms.ToolStripMenuItem();
			this.notes = new System.Windows.Forms.TreeView();
			this.button1 = new System.Windows.Forms.Button();
			this.noteFormatMenu.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// noteFormatMenu
			// 
			this.noteFormatMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.noteFormatMenu.AutoSize = false;
			this.noteFormatMenu.BackColor = System.Drawing.SystemColors.Window;
			this.noteFormatMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.noteFormatMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.noteFormatMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnNewNote,
            this.btnSaveNote,
            this.toolStripSeparator5,
            this.btnCutText,
            this.btnCopyText,
            this.btnPasteText,
            this.toolStripSeparator3,
            this.btnRedoAction,
            this.btnUndoAction,
            this.toolStripSeparator4,
            this.btnBoldText,
            this.btnItalicText,
            this.btnUnderlineText,
            this.btnStrikethroughText,
            this.toolStripSeparator2,
            this.deleteCurrentNote});
			this.noteFormatMenu.Location = new System.Drawing.Point(317, 0);
			this.noteFormatMenu.Name = "noteFormatMenu";
			this.noteFormatMenu.Size = new System.Drawing.Size(460, 25);
			this.noteFormatMenu.TabIndex = 0;
			this.noteFormatMenu.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "«";
			this.toolStripButton1.ToolTipText = "Toggle Note List";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnNewNote
			// 
			this.btnNewNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnNewNote.Image = global::TextEditor.Properties.Resources.newDoc;
			this.btnNewNote.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNewNote.Name = "btnNewNote";
			this.btnNewNote.Size = new System.Drawing.Size(23, 22);
			this.btnNewNote.Text = "toolStripButton2";
			this.btnNewNote.ToolTipText = "Create New Note";
			this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
			// 
			// btnSaveNote
			// 
			this.btnSaveNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSaveNote.Image = global::TextEditor.Properties.Resources.saveDoc;
			this.btnSaveNote.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveNote.Name = "btnSaveNote";
			this.btnSaveNote.Size = new System.Drawing.Size(23, 22);
			this.btnSaveNote.Text = "toolStripButton2";
			this.btnSaveNote.ToolTipText = "Save Changes";
			this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// btnCutText
			// 
			this.btnCutText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCutText.Image = global::TextEditor.Properties.Resources.cutText;
			this.btnCutText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCutText.Name = "btnCutText";
			this.btnCutText.Size = new System.Drawing.Size(23, 22);
			this.btnCutText.Text = "toolStripButton3";
			this.btnCutText.ToolTipText = "Cut Text";
			this.btnCutText.Click += new System.EventHandler(this.btnCutText_Click);
			// 
			// btnCopyText
			// 
			this.btnCopyText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCopyText.Image = global::TextEditor.Properties.Resources.copyText;
			this.btnCopyText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCopyText.Name = "btnCopyText";
			this.btnCopyText.Size = new System.Drawing.Size(23, 22);
			this.btnCopyText.Text = "toolStripButton4";
			this.btnCopyText.ToolTipText = "Copy Text";
			this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
			// 
			// btnPasteText
			// 
			this.btnPasteText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPasteText.Image = global::TextEditor.Properties.Resources.pasteText;
			this.btnPasteText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPasteText.Name = "btnPasteText";
			this.btnPasteText.Size = new System.Drawing.Size(23, 22);
			this.btnPasteText.Text = "toolStripButton5";
			this.btnPasteText.ToolTipText = "Paste Text";
			this.btnPasteText.Click += new System.EventHandler(this.btnPasteText_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// btnRedoAction
			// 
			this.btnRedoAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRedoAction.Image = global::TextEditor.Properties.Resources.redoAction;
			this.btnRedoAction.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRedoAction.Name = "btnRedoAction";
			this.btnRedoAction.Size = new System.Drawing.Size(23, 22);
			this.btnRedoAction.Text = "toolStripButton2";
			this.btnRedoAction.ToolTipText = "Redo Action";
			this.btnRedoAction.Click += new System.EventHandler(this.btnRedoAction_Click);
			// 
			// btnUndoAction
			// 
			this.btnUndoAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnUndoAction.Image = global::TextEditor.Properties.Resources.undoAction;
			this.btnUndoAction.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUndoAction.Name = "btnUndoAction";
			this.btnUndoAction.Size = new System.Drawing.Size(23, 22);
			this.btnUndoAction.Text = "toolStripButton3";
			this.btnUndoAction.ToolTipText = "Undo Action";
			this.btnUndoAction.Click += new System.EventHandler(this.btnUndoAction_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// btnBoldText
			// 
			this.btnBoldText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnBoldText.Image = global::TextEditor.Properties.Resources.boldText;
			this.btnBoldText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBoldText.Name = "btnBoldText";
			this.btnBoldText.Size = new System.Drawing.Size(23, 22);
			this.btnBoldText.Text = "toolStripButton4";
			this.btnBoldText.ToolTipText = "Bold Text";
			this.btnBoldText.Click += new System.EventHandler(this.btnBoldText_Click);
			// 
			// btnItalicText
			// 
			this.btnItalicText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnItalicText.Image = global::TextEditor.Properties.Resources.italicText;
			this.btnItalicText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnItalicText.Name = "btnItalicText";
			this.btnItalicText.Size = new System.Drawing.Size(23, 22);
			this.btnItalicText.Text = "toolStripButton5";
			this.btnItalicText.ToolTipText = "Italic Text";
			this.btnItalicText.Click += new System.EventHandler(this.btnItalicText_Click);
			// 
			// btnUnderlineText
			// 
			this.btnUnderlineText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnUnderlineText.Image = global::TextEditor.Properties.Resources.strikethroughText;
			this.btnUnderlineText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUnderlineText.Name = "btnUnderlineText";
			this.btnUnderlineText.Size = new System.Drawing.Size(23, 22);
			this.btnUnderlineText.Text = "toolStripButton6";
			this.btnUnderlineText.ToolTipText = "Strikethrough Text";
			this.btnUnderlineText.Click += new System.EventHandler(this.btnUnderlineText_Click);
			// 
			// btnStrikethroughText
			// 
			this.btnStrikethroughText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnStrikethroughText.Image = global::TextEditor.Properties.Resources.underlineText;
			this.btnStrikethroughText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnStrikethroughText.Name = "btnStrikethroughText";
			this.btnStrikethroughText.Size = new System.Drawing.Size(23, 22);
			this.btnStrikethroughText.Text = "toolStripButton7";
			this.btnStrikethroughText.ToolTipText = "Underline Text";
			this.btnStrikethroughText.Click += new System.EventHandler(this.btnStrikethroughText_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator2.Visible = false;
			// 
			// deleteCurrentNote
			// 
			this.deleteCurrentNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.deleteCurrentNote.Enabled = false;
			this.deleteCurrentNote.Image = ((System.Drawing.Image)(resources.GetObject("deleteCurrentNote.Image")));
			this.deleteCurrentNote.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteCurrentNote.Name = "deleteCurrentNote";
			this.deleteCurrentNote.Size = new System.Drawing.Size(97, 22);
			this.deleteCurrentNote.Text = "Delete This Note";
			this.deleteCurrentNote.Visible = false;
			this.deleteCurrentNote.Click += new System.EventHandler(this.deleteCurrentNote_Click);
			// 
			// editor
			// 
			this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editor.Enabled = false;
			this.editor.Location = new System.Drawing.Point(317, 25);
			this.editor.Name = "editor";
			this.editor.Size = new System.Drawing.Size(460, 443);
			this.editor.TabIndex = 2;
			this.editor.Text = "";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewNote});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
			// 
			// menuNewNote
			// 
			this.menuNewNote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtNoteTitle,
            this.btnCreateNewNote});
			this.menuNewNote.Name = "menuNewNote";
			this.menuNewNote.Size = new System.Drawing.Size(127, 22);
			this.menuNewNote.Text = "New Note";
			// 
			// txtNoteTitle
			// 
			this.txtNoteTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtNoteTitle.Name = "txtNoteTitle";
			this.txtNoteTitle.Size = new System.Drawing.Size(100, 23);
			// 
			// btnCreateNewNote
			// 
			this.btnCreateNewNote.Name = "btnCreateNewNote";
			this.btnCreateNewNote.Size = new System.Drawing.Size(164, 22);
			this.btnCreateNewNote.Text = "Create New Note";
			this.btnCreateNewNote.Click += new System.EventHandler(this.btnCreateNewNote_Click);
			// 
			// notes
			// 
			this.notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.notes.ContextMenuStrip = this.contextMenuStrip1;
			this.notes.Location = new System.Drawing.Point(0, 0);
			this.notes.Name = "notes";
			this.notes.Size = new System.Drawing.Size(317, 468);
			this.notes.TabIndex = 3;
			this.notes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notes_KeyPress);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button1.Location = new System.Drawing.Point(0, 468);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(777, 30);
			this.button1.TabIndex = 4;
			this.button1.Text = "How To Use (IMPORTANT TO KNOW FOR FIRST-TIME-USE)";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Notepad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(777, 498);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.notes);
			this.Controls.Add(this.editor);
			this.Controls.Add(this.noteFormatMenu);
			this.DoubleBuffered = true;
			this.Name = "Notepad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Notepad";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notepad_FormClosed);
			this.noteFormatMenu.ResumeLayout(false);
			this.noteFormatMenu.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip noteFormatMenu;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuNewNote;
		private System.Windows.Forms.ToolStripTextBox txtNoteTitle;
		private System.Windows.Forms.ToolStripMenuItem btnCreateNewNote;
		private System.Windows.Forms.ToolStripButton btnNewNote;
		private System.Windows.Forms.ToolStripButton btnCutText;
		private System.Windows.Forms.ToolStripButton btnCopyText;
		private System.Windows.Forms.ToolStripButton btnPasteText;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnRedoAction;
		private System.Windows.Forms.ToolStripButton btnUndoAction;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnBoldText;
		private System.Windows.Forms.ToolStripButton btnItalicText;
		private System.Windows.Forms.ToolStripButton btnUnderlineText;
		private System.Windows.Forms.ToolStripButton btnStrikethroughText;
		private System.Windows.Forms.ToolStripButton btnSaveNote;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		public System.Windows.Forms.RichTextBox editor;
		private System.Windows.Forms.TreeView notes;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton deleteCurrentNote;
		private System.Windows.Forms.Button button1;
	}
}