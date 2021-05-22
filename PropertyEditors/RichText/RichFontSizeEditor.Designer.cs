
namespace TextEditor.PropertyEditors.RichText
{
	partial class RichFontSizeEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichFontSizeEditor));
			this.fontSizeDecimal = new System.Windows.Forms.NumericUpDown();
			this.confirmInput = new System.Windows.Forms.Button();
			this.fontSizeWhole = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fontSizeDecimal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fontSizeWhole)).BeginInit();
			this.SuspendLayout();
			// 
			// fontSizeDecimal
			// 
			this.fontSizeDecimal.Font = new System.Drawing.Font("Roboto", 12F);
			this.fontSizeDecimal.Location = new System.Drawing.Point(276, 73);
			this.fontSizeDecimal.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.fontSizeDecimal.Name = "fontSizeDecimal";
			this.fontSizeDecimal.Size = new System.Drawing.Size(122, 27);
			this.fontSizeDecimal.TabIndex = 9;
			this.fontSizeDecimal.ThousandsSeparator = true;
			// 
			// confirmInput
			// 
			this.confirmInput.Font = new System.Drawing.Font("Roboto", 12F);
			this.confirmInput.Location = new System.Drawing.Point(45, 111);
			this.confirmInput.Name = "confirmInput";
			this.confirmInput.Size = new System.Drawing.Size(353, 39);
			this.confirmInput.TabIndex = 8;
			this.confirmInput.Text = "Confirm";
			this.confirmInput.UseVisualStyleBackColor = true;
			this.confirmInput.Click += new System.EventHandler(this.confirmInput_Click);
			// 
			// fontSizeWhole
			// 
			this.fontSizeWhole.Font = new System.Drawing.Font("Roboto", 12F);
			this.fontSizeWhole.Location = new System.Drawing.Point(126, 73);
			this.fontSizeWhole.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.fontSizeWhole.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.fontSizeWhole.Name = "fontSizeWhole";
			this.fontSizeWhole.Size = new System.Drawing.Size(144, 27);
			this.fontSizeWhole.TabIndex = 7;
			this.fontSizeWhole.ThousandsSeparator = true;
			this.fontSizeWhole.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto", 12F);
			this.label2.Location = new System.Drawing.Point(41, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Font Size:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto", 14F);
			this.label1.Location = new System.Drawing.Point(145, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Font Editor - Size";
			// 
			// RichFontSizeEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 181);
			this.Controls.Add(this.fontSizeDecimal);
			this.Controls.Add(this.confirmInput);
			this.Controls.Add(this.fontSizeWhole);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RichFontSizeEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Font Size Editor";
			((System.ComponentModel.ISupportInitialize)(this.fontSizeDecimal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fontSizeWhole)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown fontSizeDecimal;
		private System.Windows.Forms.Button confirmInput;
		private System.Windows.Forms.NumericUpDown fontSizeWhole;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}