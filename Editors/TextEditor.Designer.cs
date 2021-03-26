
namespace TextEditor.Editors
{
	partial class TextEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.openFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.newFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.viewFile = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.undoAction = new System.Windows.Forms.ToolStripMenuItem();
			this.redoAction = new System.Windows.Forms.ToolStripMenuItem();
			this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.editorFont = new System.Windows.Forms.ToolStripMenuItem();
			this.editorFontSize = new System.Windows.Forms.ToolStripMenuItem();
			this.editorFontFamily = new System.Windows.Forms.ToolStripMenuItem();
			this.advancedEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editorHRuler = new System.Windows.Forms.ToolStripMenuItem();
			this.editorVisibleSpacesTabs = new System.Windows.Forms.ToolStripMenuItem();
			this.editorShowCurrentLine = new System.Windows.Forms.ToolStripMenuItem();
			this.advancedTextEditor = new ICSharpCode.TextEditor.TextEditorControl();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.formatMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(777, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.toolStripMenuItem1,
            this.saveFile,
            this.saveFileAs,
            this.toolStripMenuItem2,
            this.newFile,
            this.toolStripMenuItem3,
            this.viewFile});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "File";
			// 
			// openFile
			// 
			this.openFile.Name = "openFile";
			this.openFile.Size = new System.Drawing.Size(200, 22);
			this.openFile.Text = "Open";
			this.openFile.Click += new System.EventHandler(this.openFile_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 6);
			// 
			// saveFile
			// 
			this.saveFile.Name = "saveFile";
			this.saveFile.Size = new System.Drawing.Size(200, 22);
			this.saveFile.Text = "Save";
			this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
			// 
			// saveFileAs
			// 
			this.saveFileAs.Name = "saveFileAs";
			this.saveFileAs.Size = new System.Drawing.Size(200, 22);
			this.saveFileAs.Text = "Save As";
			this.saveFileAs.Click += new System.EventHandler(this.saveFileAs_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 6);
			// 
			// newFile
			// 
			this.newFile.Name = "newFile";
			this.newFile.Size = new System.Drawing.Size(200, 22);
			this.newFile.Text = "New";
			this.newFile.Click += new System.EventHandler(this.newFile_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(197, 6);
			// 
			// viewFile
			// 
			this.viewFile.Name = "viewFile";
			this.viewFile.Size = new System.Drawing.Size(200, 22);
			this.viewFile.Text = "View File in File Explorer";
			this.viewFile.Click += new System.EventHandler(this.viewFile_Click);
			// 
			// editMenu
			// 
			this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoAction,
            this.redoAction});
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new System.Drawing.Size(39, 20);
			this.editMenu.Text = "Edit";
			// 
			// undoAction
			// 
			this.undoAction.Name = "undoAction";
			this.undoAction.Size = new System.Drawing.Size(180, 22);
			this.undoAction.Text = "Undo";
			this.undoAction.Click += new System.EventHandler(this.undoAction_Click);
			// 
			// redoAction
			// 
			this.redoAction.Name = "redoAction";
			this.redoAction.Size = new System.Drawing.Size(180, 22);
			this.redoAction.Text = "Redo";
			this.redoAction.Click += new System.EventHandler(this.redoAction_Click);
			// 
			// formatMenu
			// 
			this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorFont,
            this.advancedEditorToolStripMenuItem});
			this.formatMenu.Name = "formatMenu";
			this.formatMenu.Size = new System.Drawing.Size(57, 20);
			this.formatMenu.Text = "Format";
			// 
			// editorFont
			// 
			this.editorFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorFontSize,
            this.editorFontFamily});
			this.editorFont.Name = "editorFont";
			this.editorFont.Size = new System.Drawing.Size(180, 22);
			this.editorFont.Text = "Font";
			// 
			// editorFontSize
			// 
			this.editorFontSize.Name = "editorFontSize";
			this.editorFontSize.Size = new System.Drawing.Size(180, 22);
			this.editorFontSize.Text = "Size";
			this.editorFontSize.Click += new System.EventHandler(this.editorFontSize_Click);
			// 
			// editorFontFamily
			// 
			this.editorFontFamily.Name = "editorFontFamily";
			this.editorFontFamily.Size = new System.Drawing.Size(180, 22);
			this.editorFontFamily.Text = "Family";
			this.editorFontFamily.Click += new System.EventHandler(this.editorFontFamily_Click);
			// 
			// advancedEditorToolStripMenuItem
			// 
			this.advancedEditorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorHRuler,
            this.editorVisibleSpacesTabs,
            this.editorShowCurrentLine});
			this.advancedEditorToolStripMenuItem.Name = "advancedEditorToolStripMenuItem";
			this.advancedEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.advancedEditorToolStripMenuItem.Text = "Advanced Editor";
			// 
			// editorHRuler
			// 
			this.editorHRuler.CheckOnClick = true;
			this.editorHRuler.Name = "editorHRuler";
			this.editorHRuler.Size = new System.Drawing.Size(184, 22);
			this.editorHRuler.Text = "HRuler";
			this.editorHRuler.Click += new System.EventHandler(this.editorHRuler_Click);
			// 
			// editorVisibleSpacesTabs
			// 
			this.editorVisibleSpacesTabs.CheckOnClick = true;
			this.editorVisibleSpacesTabs.Name = "editorVisibleSpacesTabs";
			this.editorVisibleSpacesTabs.Size = new System.Drawing.Size(184, 22);
			this.editorVisibleSpacesTabs.Text = "Show Spaces/Tabs";
			this.editorVisibleSpacesTabs.Click += new System.EventHandler(this.editorVisibleSpacesTabs_Click);
			// 
			// editorShowCurrentLine
			// 
			this.editorShowCurrentLine.CheckOnClick = true;
			this.editorShowCurrentLine.Name = "editorShowCurrentLine";
			this.editorShowCurrentLine.Size = new System.Drawing.Size(184, 22);
			this.editorShowCurrentLine.Text = "Display Selected Line";
			this.editorShowCurrentLine.Click += new System.EventHandler(this.editorShowCurrentLine_Click);
			// 
			// advancedTextEditor
			// 
			this.advancedTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.advancedTextEditor.IsReadOnly = false;
			this.advancedTextEditor.Location = new System.Drawing.Point(0, 24);
			this.advancedTextEditor.Name = "advancedTextEditor";
			this.advancedTextEditor.Size = new System.Drawing.Size(777, 473);
			this.advancedTextEditor.TabIndex = 1;
			// 
			// TextEditor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(777, 497);
			this.Controls.Add(this.advancedTextEditor);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Roboto", 14F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "TextEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TextEditor";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextEditor_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem editMenu;
		private System.Windows.Forms.ToolStripMenuItem formatMenu;
		private System.Windows.Forms.ToolStripMenuItem openFile;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveFile;
		private System.Windows.Forms.ToolStripMenuItem saveFileAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem newFile;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem viewFile;
		private System.Windows.Forms.ToolStripMenuItem editorFont;
		private System.Windows.Forms.ToolStripMenuItem editorFontSize;
		private System.Windows.Forms.ToolStripMenuItem editorFontFamily;
		private System.Windows.Forms.ToolStripMenuItem advancedEditorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editorHRuler;
		private System.Windows.Forms.ToolStripMenuItem editorVisibleSpacesTabs;
		private System.Windows.Forms.ToolStripMenuItem editorShowCurrentLine;
		private ICSharpCode.TextEditor.TextEditorControl advancedTextEditor;
		private System.Windows.Forms.ToolStripMenuItem undoAction;
		private System.Windows.Forms.ToolStripMenuItem redoAction;
	}
}