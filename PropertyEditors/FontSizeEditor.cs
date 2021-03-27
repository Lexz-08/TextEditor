using DropShadow;
using FastColoredTextBoxNS;
using ICSharpCode.TextEditor;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor.PropertyEditors
{
	public partial class FontSizeEditor : Form
	{
		public FontSizeEditor(RichTextBox basicEditor, TextEditorControl advancedEditor, FastColoredTextBox superAdvancedEditor)
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

			this.basicEditor = basicEditor;
			this.advancedEditor = advancedEditor;
			this.superAdvancedEditor = superAdvancedEditor;

			string[] fontSizeParts = new string[2];
			if (basicEditor != null && advancedEditor == null && superAdvancedEditor == null)
			{
				string fontSizeStr = basicEditor.Font.Size.ToString();
				if (fontSizeStr.Contains("."))
				{
					fontSizeParts = fontSizeStr.Split('.');
					fontSizeWhole.Value = Convert.ToDecimal(fontSizeParts[0]);
					fontSizeDecimal.Value = Convert.ToDecimal(fontSizeParts[1]);
				}
				else
				{
					fontSizeWhole.Value = Convert.ToDecimal(fontSizeStr);
					fontSizeDecimal.Value = 0;
				}
			}
			else if (basicEditor == null && advancedEditor != null && superAdvancedEditor == null)
			{
				string fontSizeStr = advancedEditor.Font.Size.ToString();
				if (fontSizeStr.Contains("."))
				{
					fontSizeParts = fontSizeStr.Split('.');
					fontSizeWhole.Value = Convert.ToDecimal(fontSizeParts[0]);
					fontSizeDecimal.Value = Convert.ToDecimal(fontSizeParts[1]);
				}
				else
				{
					fontSizeWhole.Value = Convert.ToDecimal(fontSizeStr);
					fontSizeDecimal.Value = 0;
				}
			}
			if (basicEditor == null && advancedEditor == null && superAdvancedEditor != null)
			{
				string fontSizeStr = superAdvancedEditor.Font.Size.ToString();
				if (fontSizeStr.Contains("."))
				{
					fontSizeParts = fontSizeStr.Split('.');
					fontSizeWhole.Value = Convert.ToDecimal(fontSizeParts[0]);
					fontSizeDecimal.Value = Convert.ToDecimal(fontSizeParts[1]);
				}
				else
				{
					fontSizeWhole.Value = Convert.ToDecimal(fontSizeStr);
					fontSizeDecimal.Value = 0;
				}
			}
		}

		private RichTextBox basicEditor = null;
		private TextEditorControl advancedEditor = null;
		private FastColoredTextBox superAdvancedEditor = null;

		private void confirmInput_Click(object sender, System.EventArgs e)
		{
			string fontSize = fontSizeWhole.Value + "." + fontSizeDecimal.Value;
			float fontSizeFloat = Convert.ToSingle(fontSize);

			if (basicEditor != null && advancedEditor == null && superAdvancedEditor == null)
				basicEditor.Font = new Font(basicEditor.Font.Name, fontSizeFloat);
			else if (basicEditor == null && advancedEditor != null && superAdvancedEditor == null)
				advancedEditor.Font = new Font(advancedEditor.Font.Name, fontSizeFloat);
			else if (basicEditor == null && advancedEditor == null && superAdvancedEditor != null)
				superAdvancedEditor.Font = new Font(superAdvancedEditor.Font.Name, fontSizeFloat);

			Close();
		}
	}
}
