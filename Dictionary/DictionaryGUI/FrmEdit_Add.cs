using System.Windows.Forms;
using DictionaryGUI.Data;
using System.Linq;

namespace DictionaryGUI
{
    public partial class FrmEdit_Add : Form
    {
        private bool shouldAdd = false;

        private string[] key = new string[2];

        public FrmEdit_Add(bool shouldAdd, string word = "", int type = -1, string mean = "")
        {
            InitializeComponent();
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
                    this.cboType.SelectedIndex = type;
                    this.txtMean.Text = mean;
                    this.btnPerform.Text = "Save";
                }
            };
            this.btnPerform.Click += (sender, e) => PerformAction();
            this.btnCancel.Click += (sender, e) => this.Dispose();
        }

        private void PerformAction()
        {
            var db = new DictionaryEntities();
            if (this.shouldAdd)
            {
                db.Words.Add(new Word { word_o = txtWord.Text,
                                        type_id = cboType.SelectedIndex + 1,
                                        word_m = txtMean.Text });
                MessageBox.Show("Row added successfully");
            }
            else
            {
                Word data = db.Words.Find(key[0], int.Parse(key[1]) + 1);
                data.word_m = txtMean.Text;
                MessageBox.Show("Data edited successfully");
            }
            db.SaveChanges();
            db.Dispose();
            this.btnCancel.PerformClick();
        }

        private void LoadTypeList()
        {
            DictionaryEntities db = new DictionaryEntities();
            var data = db.Types.Select(item => item.type_description);
            this.cboType.DataSource = data.ToList();
            db.Dispose();
        }
    }
}
