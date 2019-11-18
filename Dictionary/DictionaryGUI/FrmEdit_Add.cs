using System.Windows.Forms;

namespace DictionaryGUI
{
    public partial class FrmEdit_Add : Form
    {
        public FrmEdit_Add()
        {
            InitializeComponent();
            this.btnCancel.Click += (sender, e) => this.Close();
        }
    }
}
