
namespace TextEditor.Editors
{
	partial class CodeEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditor));
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
			this.cutText = new System.Windows.Forms.ToolStripMenuItem();
			this.copyText = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.pasteText = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.undoAction = new System.Windows.Forms.ToolStripMenuItem();
			this.redoAction = new System.Windows.Forms.ToolStripMenuItem();
			this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.editorFont = new System.Windows.Forms.ToolStripMenuItem();
			this.editorFontSize = new System.Windows.Forms.ToolStripMenuItem();
			this.editorFontFamily = new System.Windows.Forms.ToolStripMenuItem();
			this.editorWordWrap = new System.Windows.Forms.ToolStripMenuItem();
			this.btnShowMnuItmChecked = new System.Windows.Forms.ToolStripMenuItem();
			this.advancedEditor = new FastColoredTextBoxNS.FastColoredTextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.currentFont = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.currentWordWrap = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.drpdwnSelectLanguage = new System.Windows.Forms.ToolStripDropDownButton();
			this.btnlangCustom = new System.Windows.Forms.ToolStripMenuItem();
			this.btnlangCSharp = new System.Windows.Forms.ToolStripMenuItem();
			this.btnlangVisualBasic = new System.Windows.Forms.ToolStripMenuItem();
			this.btnlangHTML = new System.Windows.Forms.ToolStripMenuItem();
			this.btnlangXML = new System.Windows.Forms.ToolStripMenuItem();
			this.btnlangSQL = new System.Windows.Forms.ToolStripMenuItem();
			this.btnlangPHP = new System.Windows.Forms.ToolStripMenuItem();
			this.btnlangJS = new System.Windows.Forms.ToolStripMenuItem();
			this.btnlangLua = new System.Windows.Forms.ToolStripMenuItem();
			this.currentLanguage = new System.Windows.Forms.ToolStripLabel();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.advancedEditor)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.formatMenu,
            this.btnShowMnuItmChecked});
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
			this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openFile.Size = new System.Drawing.Size(273, 22);
			this.openFile.Text = "Open";
			this.openFile.Click += new System.EventHandler(this.openFile_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(270, 6);
			// 
			// saveFile
			// 
			this.saveFile.Name = "saveFile";
			this.saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveFile.Size = new System.Drawing.Size(273, 22);
			this.saveFile.Text = "Save";
			this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
			// 
			// saveFileAs
			// 
			this.saveFileAs.Name = "saveFileAs";
			this.saveFileAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveFileAs.Size = new System.Drawing.Size(273, 22);
			this.saveFileAs.Text = "Save As";
			this.saveFileAs.Click += new System.EventHandler(this.saveFileAs_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(270, 6);
			// 
			// newFile
			// 
			this.newFile.Name = "newFile";
			this.newFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newFile.Size = new System.Drawing.Size(273, 22);
			this.newFile.Text = "New";
			this.newFile.Click += new System.EventHandler(this.newFile_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(270, 6);
			// 
			// viewFile
			// 
			this.viewFile.Name = "viewFile";
			this.viewFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
			this.viewFile.Size = new System.Drawing.Size(273, 22);
			this.viewFile.Text = "View File in File Explorer";
			this.viewFile.Click += new System.EventHandler(this.viewFile_Click);
			// 
			// editMenu
			// 
			this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutText,
            this.copyText,
            this.toolStripMenuItem4,
            this.pasteText,
            this.toolStripMenuItem5,
            this.undoAction,
            this.redoAction});
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new System.Drawing.Size(39, 20);
			this.editMenu.Text = "Edit";
			// 
			// cutText
			// 
			this.cutText.Name = "cutText";
			this.cutText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutText.Size = new System.Drawing.Size(144, 22);
			this.cutText.Text = "Cut";
			this.cutText.Click += new System.EventHandler(this.cutText_Click);
			// 
			// copyText
			// 
			this.copyText.Name = "copyText";
			this.copyText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyText.Size = new System.Drawing.Size(144, 22);
			this.copyText.Text = "Copy";
			this.copyText.Click += new System.EventHandler(this.copyText_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(141, 6);
			// 
			// pasteText
			// 
			this.pasteText.Name = "pasteText";
			this.pasteText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteText.Size = new System.Drawing.Size(144, 22);
			this.pasteText.Text = "Paste";
			this.pasteText.Click += new System.EventHandler(this.pasteText_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(141, 6);
			// 
			// undoAction
			// 
			this.undoAction.Name = "undoAction";
			this.undoAction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoAction.Size = new System.Drawing.Size(144, 22);
			this.undoAction.Text = "Undo";
			this.undoAction.Click += new System.EventHandler(this.undoAction_Click);
			// 
			// redoAction
			// 
			this.redoAction.Name = "redoAction";
			this.redoAction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoAction.Size = new System.Drawing.Size(144, 22);
			this.redoAction.Text = "Redo";
			this.redoAction.Click += new System.EventHandler(this.redoAction_Click);
			// 
			// formatMenu
			// 
			this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorFont,
            this.editorWordWrap});
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
			this.editorFont.Size = new System.Drawing.Size(202, 22);
			this.editorFont.Text = "Font";
			// 
			// editorFontSize
			// 
			this.editorFontSize.Name = "editorFontSize";
			this.editorFontSize.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
			this.editorFontSize.Size = new System.Drawing.Size(172, 22);
			this.editorFontSize.Text = "Size";
			this.editorFontSize.Click += new System.EventHandler(this.editorFontSize_Click);
			// 
			// editorFontFamily
			// 
			this.editorFontFamily.Name = "editorFontFamily";
			this.editorFontFamily.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
			this.editorFontFamily.Size = new System.Drawing.Size(172, 22);
			this.editorFontFamily.Text = "Family";
			this.editorFontFamily.Click += new System.EventHandler(this.editorFontFamily_Click);
			// 
			// editorWordWrap
			// 
			this.editorWordWrap.CheckOnClick = true;
			this.editorWordWrap.Name = "editorWordWrap";
			this.editorWordWrap.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.W)));
			this.editorWordWrap.Size = new System.Drawing.Size(202, 22);
			this.editorWordWrap.Text = "Word Wrap";
			this.editorWordWrap.Click += new System.EventHandler(this.editorWordWrap_Click);
			// 
			// btnShowMnuItmChecked
			// 
			this.btnShowMnuItmChecked.Name = "btnShowMnuItmChecked";
			this.btnShowMnuItmChecked.Size = new System.Drawing.Size(187, 20);
			this.btnShowMnuItmChecked.Text = "Show Menu Items Checked: ON";
			this.btnShowMnuItmChecked.Click += new System.EventHandler(this.btnShowMnuItmChecked_Click);
			// 
			// advancedEditor
			// 
			this.advancedEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.advancedEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.advancedEditor.AutoScrollMinSize = new System.Drawing.Size(25, 15);
			this.advancedEditor.BackBrush = null;
			this.advancedEditor.CharHeight = 15;
			this.advancedEditor.CharWidth = 7;
			this.advancedEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.advancedEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.advancedEditor.Font = new System.Drawing.Font("Consolas", 9.75F);
			this.advancedEditor.IsReplaceMode = false;
			this.advancedEditor.LineNumberColor = System.Drawing.Color.Black;
			this.advancedEditor.Location = new System.Drawing.Point(0, 24);
			this.advancedEditor.Name = "advancedEditor";
			this.advancedEditor.Paddings = new System.Windows.Forms.Padding(0);
			this.advancedEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.advancedEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("advancedEditor.ServiceColors")));
			this.advancedEditor.Size = new System.Drawing.Size(777, 448);
			this.advancedEditor.TabIndex = 1;
			this.advancedEditor.Zoom = 100;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentFont,
            this.toolStripSeparator1,
            this.currentWordWrap,
            this.toolStripSeparator2,
            this.drpdwnSelectLanguage,
            this.currentLanguage});
			this.toolStrip1.Location = new System.Drawing.Point(0, 472);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(777, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// currentFont
			// 
			this.currentFont.Name = "currentFont";
			this.currentFont.Size = new System.Drawing.Size(93, 22);
			this.currentFont.Text = "Consolas, 9.75pt";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// currentWordWrap
			// 
			this.currentWordWrap.Name = "currentWordWrap";
			this.currentWordWrap.Size = new System.Drawing.Size(111, 22);
			this.currentWordWrap.Text = "WordWrap: Inactive";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// drpdwnSelectLanguage
			// 
			this.drpdwnSelectLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.drpdwnSelectLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnlangCustom,
            this.btnlangCSharp,
            this.btnlangVisualBasic,
            this.btnlangHTML,
            this.btnlangXML,
            this.btnlangSQL,
            this.btnlangPHP,
            this.btnlangJS,
            this.btnlangLua});
			this.drpdwnSelectLanguage.Image = ((System.Drawing.Image)(resources.GetObject("drpdwnSelectLanguage.Image")));
			this.drpdwnSelectLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.drpdwnSelectLanguage.Name = "drpdwnSelectLanguage";
			this.drpdwnSelectLanguage.Size = new System.Drawing.Size(106, 22);
			this.drpdwnSelectLanguage.Text = "Select Language";
			// 
			// btnlangCustom
			// 
			this.btnlangCustom.Checked = true;
			this.btnlangCustom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.btnlangCustom.Name = "btnlangCustom";
			this.btnlangCustom.Size = new System.Drawing.Size(135, 22);
			this.btnlangCustom.Text = "Custom";
			this.btnlangCustom.Click += new System.EventHandler(this.btnlangCustom_Click);
			// 
			// btnlangCSharp
			// 
			this.btnlangCSharp.Name = "btnlangCSharp";
			this.btnlangCSharp.Size = new System.Drawing.Size(135, 22);
			this.btnlangCSharp.Text = "CSharp";
			this.btnlangCSharp.Click += new System.EventHandler(this.btnlangCSharp_Click);
			// 
			// btnlangVisualBasic
			// 
			this.btnlangVisualBasic.Name = "btnlangVisualBasic";
			this.btnlangVisualBasic.Size = new System.Drawing.Size(135, 22);
			this.btnlangVisualBasic.Text = "Visual Basic";
			this.btnlangVisualBasic.Click += new System.EventHandler(this.btnlangVisualBasic_Click);
			// 
			// btnlangHTML
			// 
			this.btnlangHTML.Name = "btnlangHTML";
			this.btnlangHTML.Size = new System.Drawing.Size(135, 22);
			this.btnlangHTML.Text = "HTML";
			this.btnlangHTML.Click += new System.EventHandler(this.btnlangHTML_Click);
			// 
			// btnlangXML
			// 
			this.btnlangXML.Name = "btnlangXML";
			this.btnlangXML.Size = new System.Drawing.Size(135, 22);
			this.btnlangXML.Text = "XML";
			this.btnlangXML.Click += new System.EventHandler(this.btnlangXML_Click);
			// 
			// btnlangSQL
			// 
			this.btnlangSQL.Name = "btnlangSQL";
			this.btnlangSQL.Size = new System.Drawing.Size(135, 22);
			this.btnlangSQL.Text = "SQL";
			this.btnlangSQL.Click += new System.EventHandler(this.btnlangSQL_Click);
			// 
			// btnlangPHP
			// 
			this.btnlangPHP.Name = "btnlangPHP";
			this.btnlangPHP.Size = new System.Drawing.Size(135, 22);
			this.btnlangPHP.Text = "PHP";
			this.btnlangPHP.Click += new System.EventHandler(this.btnlangPHP_Click);
			// 
			// btnlangJS
			// 
			this.btnlangJS.Name = "btnlangJS";
			this.btnlangJS.Size = new System.Drawing.Size(135, 22);
			this.btnlangJS.Text = "JS";
			this.btnlangJS.Click += new System.EventHandler(this.btnlangJS_Click);
			// 
			// btnlangLua
			// 
			this.btnlangLua.Name = "btnlangLua";
			this.btnlangLua.Size = new System.Drawing.Size(135, 22);
			this.btnlangLua.Text = "Lua";
			this.btnlangLua.Click += new System.EventHandler(this.btnlangLua_Click);
			// 
			// currentLanguage
			// 
			this.currentLanguage.Name = "currentLanguage";
			this.currentLanguage.Size = new System.Drawing.Size(49, 22);
			this.currentLanguage.Text = "Custom";
			// 
			// CodeEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(777, 497);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.advancedEditor);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CodeEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CodeEditor";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeEditor_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.advancedEditor)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
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
		private System.Windows.Forms.ToolStripMenuItem cutText;
		private System.Windows.Forms.ToolStripMenuItem copyText;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem pasteText;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem undoAction;
		private System.Windows.Forms.ToolStripMenuItem redoAction;
		private System.Windows.Forms.ToolStripMenuItem editorFont;
		private System.Windows.Forms.ToolStripMenuItem editorFontSize;
		private System.Windows.Forms.ToolStripMenuItem editorFontFamily;
		private System.Windows.Forms.ToolStripMenuItem editorWordWrap;
		private FastColoredTextBoxNS.FastColoredTextBox advancedEditor;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel currentFont;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel currentLanguage;
		private System.Windows.Forms.ToolStripLabel currentWordWrap;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripDropDownButton drpdwnSelectLanguage;
		private System.Windows.Forms.ToolStripMenuItem btnlangCustom;
		private System.Windows.Forms.ToolStripMenuItem btnlangCSharp;
		private System.Windows.Forms.ToolStripMenuItem btnlangVisualBasic;
		private System.Windows.Forms.ToolStripMenuItem btnlangHTML;
		private System.Windows.Forms.ToolStripMenuItem btnlangXML;
		private System.Windows.Forms.ToolStripMenuItem btnlangSQL;
		private System.Windows.Forms.ToolStripMenuItem btnlangPHP;
		private System.Windows.Forms.ToolStripMenuItem btnlangJS;
		private System.Windows.Forms.ToolStripMenuItem btnlangLua;
		private System.Windows.Forms.ToolStripMenuItem btnShowMnuItmChecked;
	}
}