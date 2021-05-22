using DropShadow;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace TextEditor.PropertyEditors.RichText
{
	public partial class RichFontNameEditor : Form
	{
		public RichFontNameEditor(RichTextBox richEditor)
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

			string[] installedFontNames = new string[0];
			installedFontNames = GetInstalledFonts();
			fontName.Items.AddRange(installedFontNames);

			this.richEditor = richEditor;

			string editorFontName = richEditor.SelectionFont.Name;

			for (int i = 0; i < fontName.Items.Count; i++)
			{
				if (fontName.Items[i].ToString() == editorFontName)
				{
					fontName.Text = editorFontName;
				}
			}
		}

		private RichTextBox richEditor;

		private string[] GetInstalledFonts()
		{
			FontFamily[] installedFamilies = new InstalledFontCollection().Families;

			string[] fontNames = new string[installedFamilies.Length];
			for (int i = 0; i < installedFamilies.Length; i++)
			{
				fontNames[i] = installedFamilies[i].Name;
			}

			return fontNames;
		}

		private void confirmInput_Click(object sender, EventArgs e)
		{
			richEditor.SelectionFont = new Font(fontName.Text, richEditor.Font.Size);
		}
	}
}
