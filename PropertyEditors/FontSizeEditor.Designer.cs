
namespace TextEditor.PropertyEditors
{
	partial class FontSizeEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontSizeEditor));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.fontSizeWhole = new System.Windows.Forms.NumericUpDown();
			this.confirmInput = new System.Windows.Forms.Button();
			this.fontSizeDecimal = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.fontSizeWhole)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fontSizeDecimal)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto", 14F);
			this.label1.Location = new System.Drawing.Point(143, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Font Editor - Size";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto", 12F);
			this.label2.Location = new System.Drawing.Point(39, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Font Size:";
			// 
			// fontSizeWhole
			// 
			this.fontSizeWhole.Font = new System.Drawing.Font("Roboto", 12F);
			this.fontSizeWhole.Location = new System.Drawing.Point(124, 73);
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
			this.fontSizeWhole.TabIndex = 2;
			this.fontSizeWhole.ThousandsSeparator = true;
			this.fontSizeWhole.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// confirmInput
			// 
			this.confirmInput.Font = new System.Drawing.Font("Roboto", 12F);
			this.confirmInput.Location = new System.Drawing.Point(43, 111);
			this.confirmInput.Name = "confirmInput";
			this.confirmInput.Size = new System.Drawing.Size(353, 39);
			this.confirmInput.TabIndex = 3;
			this.confirmInput.Text = "Confirm";
			this.confirmInput.UseVisualStyleBackColor = true;
			this.confirmInput.Click += new System.EventHandler(this.confirmInput_Click);
			// 
			// fontSizeDecimal
			// 
			this.fontSizeDecimal.Font = new System.Drawing.Font("Roboto", 12F);
			this.fontSizeDecimal.Location = new System.Drawing.Point(274, 73);
			this.fontSizeDecimal.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.fontSizeDecimal.Name = "fontSizeDecimal";
			this.fontSizeDecimal.Size = new System.Drawing.Size(122, 27);
			this.fontSizeDecimal.TabIndex = 4;
			this.fontSizeDecimal.ThousandsSeparator = true;
			// 
			// FontSizeEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 181);
			this.Controls.Add(this.fontSizeDecimal);
			this.Controls.Add(this.confirmInput);
			this.Controls.Add(this.fontSizeWhole);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FontSizeEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Font Editor";
			((System.ComponentModel.ISupportInitialize)(this.fontSizeWhole)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fontSizeDecimal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown fontSizeWhole;
		private System.Windows.Forms.Button confirmInput;
		private System.Windows.Forms.NumericUpDown fontSizeDecimal;
	}
}