using System.Windows.Forms;
using DictionaryGUI.Data;

namespace DictionaryGUI
{
    public partial class FrmEdit_Add : Form
    {
        private bool shouldAdd = false;

        private string[] key = new string[2];

        private DatabaseManagement manager;

        public FrmEdit_Add(bool shouldAdd, string word = "", int type = -1, string mean = "")
        {
            InitializeComponent();
            manager = new DatabaseManagement();
            this.shouldAdd = shouldAdd;

            this.Load += (sender, e) =>
            {
                LoadTypeList();
                if (this.shouldAdd)
                {
                    this.btnPerform.Text = "Add";
                }
                else
                {
                    key[0] = word;
                    key[1] = type.ToString();
                    this.txtWord.Text = word;
                    this.txtWord.ReadOnly = true;
                    this.cboType.SelectedIndex = type - 1;
                    this.cboType.Enabled = false;
                    this.txtMean.Text = mean;
                    this.btnPerform.Text = "Save";
                }
            };
            this.btnPerform.DialogResult = DialogResult.Yes;
            this.btnCancel.Click += (sender, e) => this.Close();
        }

        public void PerformAction(out Word obj)
        {
            if (shouldAdd)
            {
                obj = manager.AddWord(txtWord.Text, cboType.SelectedIndex + 1, txtMean.Text);
            }else
            {
                obj = manager.EditWord(txtWord.Text, cboType.SelectedIndex + 1, txtMean.Text);
            }
            this.btnCancel.PerformClick();
        }

        private void LoadTypeList()
        {
            this.cboType.DataSource = manager.GetListTypes();
        }
    }
}
