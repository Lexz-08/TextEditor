using System.Windows.Forms;
using TextEditor.Properties;

namespace TextEditor.Editors
{
	public partial class CodeEditor : Form
	{
		public CodeEditor()
		{
			InitializeComponent();

			Icon = Resources.codeIcon;
		}
	}
}
