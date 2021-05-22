using DropShadow;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor.PropertyEditors.RichText
{
	public partial class RichFontSizeEditor : Form
	{
		public RichFontSizeEditor(RichTextBox richEditor)
		{
			InitializeComponent();

			DropShadowCS dropShadow = new DropShadowCS();
			dropShadow.CreateDropShadow(this, new Control[]
			{
				this,
				label1,
				label2,
			});
			dropShadow.CreateWNDParams(CreateParams);

			this.richEditor = richEditor;

			string[] fontSizeParts = new string[2];
			string fontSizeStr = richEditor.SelectionFont.Size.ToString();
			if (fontSizeStr.Contains("."))
			{
				fontSizeParts = fontSizeStr.Split('.');
				fontSizeWhole.Value = Convert.ToDecimal(fontSizeParts[0]);
				fontSizeDecimal.Value = Convert.ToDecimal(fontSizeParts[1].Substring(0, 2));
			}
			else
			{
				fontSizeWhole.Value = Convert.ToDecimal(fontSizeStr);
				fontSizeDecimal.Value = 0;
			}
		}

		private RichTextBox richEditor;

		private void confirmInput_Click(object sender, EventArgs e)
		{
			string fontSize = fontSizeWhole.Value + "." + fontSizeDecimal.Value;
			float fontSizeFloat = Convert.ToSingle(fontSize);

			richEditor.SelectionFont = new Font(richEditor.SelectionFont.Name, fontSizeFloat);
		}
	}
}
