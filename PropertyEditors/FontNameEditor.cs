using DropShadow;
using ICSharpCode.TextEditor;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace TextEditor.PropertyEditors
{
	public partial class FontNameEditor : Form
	{
		public FontNameEditor(RichTextBox basicEditor, TextEditorControl advancedEditor)
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

			this.basicEditor = basicEditor;
			this.advancedEditor = advancedEditor;

			if (basicEditor != null && advancedEditor == null)
			{
				string editorFontName = basicEditor.Font.Name;
				
				for (int i = 0; i < fontName.Items.Count; i++)
				{
					if (fontName.Items[i].ToString() == editorFontName)
					{
						fontName.Text = editorFontName;
					}
				}
			}
			else if (basicEditor == null && advancedEditor != null)
			{
				string editorFontName = advancedEditor.Font.Name;

				for (int i = 0; i < fontName.Items.Count; i++)
				{
					if (fontName.Items[i].ToString() == editorFontName)
					{
						fontName.Text = editorFontName;
					}
				}
			}
		}

		private RichTextBox basicEditor = null;
		private TextEditorControl advancedEditor = null;

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

		private void confirmInput_Click(object sender, System.EventArgs e)
		{
			if (basicEditor != null && advancedEditor == null)
				basicEditor.Font = new Font(fontName.Text, basicEditor.Font.Size);
			else if (basicEditor == null && advancedEditor != null)
				advancedEditor.Font = new Font(fontName.Text, advancedEditor.Font.Size);

			Close();
		}
	}
}
