using System;
using System.Windows.Forms;
using DictionaryGUI.Data;
using System.Linq;
using System.Collections.Generic;

namespace DictionaryGUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            SetHandCursor(tabSearch);
            SetHandCursor(tabManage);
            SetHandCursor(tabIm_Ex);
            SetHandCursor(boxImport);
            SetHandCursor(boxExport);
            btnPronounce.Cursor = Cursors.Hand;
            this.txtSearch.Focus();
            this.Load += GUI_Load;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
            this.recmWordsList.MouseClick += RecmWordsList_MouseClick;
            this.btnFind.Click += BtnFind_Click;
            this.btnDel.Click += (sender, e) => this.txtSearch.Clear();
            this.btnAdd.Click += (sender, e) =>
            {
                (new FrmEdit_Add(true)).ShowDialog();
                LoadWordsToManageList();
            };
            this.btnDelete.Click += BtnDelete_Click;
            this.wordsTable.CellDoubleClick += WordsTable_CellDoubleClick;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var db = new DictionaryEntities();
            var data = db.Words.Find(this.wordsTable.SelectedRows[0].Cells[0].Value.ToString(),
                                        IndexOfType(this.wordsTable.SelectedRows[0].Cells[1].Value.ToString()) + 1);
            db.Words.Remove(data);
            db.SaveChanges();
            db.Dispose();
            LoadWordsToManageList();
            MessageBox.Show("The selected row has been removed successfully");
        }

        private void WordsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string word = this.wordsTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            int type = IndexOfType(this.wordsTable.Rows[e.RowIndex].Cells[1].Value.ToString());
            string mean = this.wordsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            var editFrm = new FrmEdit_Add(false, word, type, mean);
            editFrm.ShowDialog();
            editFrm.Close();
        }

        public static int IndexOfType(string typeText)
        {
            var db = new DictionaryEntities();
            int index = db.Types.Where(item => item.type_description.Equals(typeText)).Select(item => item.type_id).ToList()[0] - 1;
            db.Dispose();
            return index;
        }

        private void RecmWordsList_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtSearch.TextChanged -= TxtSearch_TextChanged;
            int index = this.recmWordsList.IndexFromPoint(e.Location);
            this.txtSearch.Text = this.recmWordsList.Items[index].ToString();
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            ShowWordInfs(this.txtSearch.Text);
        }

        private void ShowWordInfs(string word)
        {
            this.txtMeans.Clear();
            var db = new DictionaryEntities();
            var data = db.Words.Where(item => item.word_o.ToLower().Equals(word.ToLower())).GroupBy(item => item.type_id);
            this.txtMeans.AppendText(word + Environment.NewLine);
            this.txtMeans.SelectionStart = 0;
            this.txtMeans.SelectionLength = this.txtMeans.Lines[0].Length;
            this.txtMeans.SelectionColor = System.Drawing.Color.Purple;
            foreach (var type in data)
            {
                this.txtMeans.AppendText("    - " + db.Types.Find(type.Key).type_description);
                this.txtMeans.SelectionStart = this.txtMeans.GetFirstCharIndexOfCurrentLine();
                this.txtMeans.SelectionLength = this.txtMeans.Lines[this.txtMeans.GetLineFromCharIndex(this.txtMeans.SelectionStart)].Length;
                this.txtMeans.SelectionColor = System.Drawing.Color.Blue;
                this.txtMeans.AppendText(Environment.NewLine);
                foreach (var means in type)
                {
                    this.txtMeans.AppendText("        + " + means.word_m + Environment.NewLine);
                }
            }
            db.Dispose();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowRecommendWords(this.txtSearch.Text);
        }

        private void ShowRecommendWords(string text)
        {
            var dataSource = GetDistinctWordsList();
            var data = dataSource.Where(item => item.ToLower().StartsWith(text.ToLower())).Select(item => item);
            this.recmWordsList.DataSource = data.ToList();
            this.recmWordsList.ClearSelected();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            LoadWordsToHintList();
            LoadWordsToManageList();
        }

        private void LoadWordsToManageList()
        {
            DictionaryEntities db = new DictionaryEntities();
            var data = db.Words.ToList();
            this.wordsTable.DataSource = data.Select(item => new
            {
                Word = item.word_o,
                Type = item.Type.type_description,
                Mean = item.word_m
            }).ToList();
            db.Dispose();
        }

        private void LoadWordsToHintList()
        {
            this.recmWordsList.DataSource = GetDistinctWordsList();
            this.recmWordsList.ClearSelected();
        }

        private List<string> GetDistinctWordsList()
        {
            DictionaryEntities db = new DictionaryEntities();
            var data = db.Words.Select(item => item.word_o).Distinct().ToList<string>();
            db.Dispose();
            return data;
        }

        private void SetHandCursor(Control page)
        {
            foreach (Control comp in page.Controls)
            {
                if (comp is Button)
                {
                    comp.Cursor = Cursors.Hand;
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            txtSearch.Select();
            base.OnShown(e);
        }
    }
}
