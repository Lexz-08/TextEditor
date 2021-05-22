
namespace TextEditor.PropertyEditors.RichText
{
	partial class RichFontNameEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichFontNameEditor));
			this.fontName = new System.Windows.Forms.ComboBox();
			this.confirmInput = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// fontName
			// 
			this.fontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fontName.Font = new System.Drawing.Font("Roboto", 12F);
			this.fontName.FormattingEnabled = true;
			this.fontName.Location = new System.Drawing.Point(138, 72);
			this.fontName.Name = "fontName";
			this.fontName.Size = new System.Drawing.Size(260, 27);
			this.fontName.TabIndex = 13;
			// 
			// confirmInput
			// 
			this.confirmInput.Font = new System.Drawing.Font("Roboto", 12F);
			this.confirmInput.Location = new System.Drawing.Point(45, 111);
			this.confirmInput.Name = "confirmInput";
			this.confirmInput.Size = new System.Drawing.Size(353, 39);
			this.confirmInput.TabIndex = 12;
			this.confirmInput.Text = "Confirm";
			this.confirmInput.UseVisualStyleBackColor = true;
			this.confirmInput.Click += new System.EventHandler(this.confirmInput_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto", 12F);
			this.label2.Location = new System.Drawing.Point(41, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 19);
			this.label2.TabIndex = 11;
			this.label2.Text = "Font Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto", 14F);
			this.label1.Location = new System.Drawing.Point(145, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Font Editor - Name";
			// 
			// RichFontNameEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 181);
			this.Controls.Add(this.fontName);
			this.Controls.Add(this.confirmInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RichFontNameEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Font Name Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox fontName;
		private System.Windows.Forms.Button confirmInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}