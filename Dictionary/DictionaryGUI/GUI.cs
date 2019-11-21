using System;
using System.Windows.Forms;
using System.Linq;
using DictionaryGUI.Data;
using System.Data;

namespace DictionaryGUI
{
    public partial class GUI : Form
    {
        DatabaseManagement manager;
        public GUI()
        {
            InitializeComponent();
            manager = new DatabaseManagement();
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
            this.btnClear.Click += (sender, e) => this.txtSearch.Clear();
            this.btnAdd.Click += (sender, e) =>
            {
                FrmEdit_Add frm = new FrmEdit_Add(true);
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    Word obj;
                    frm.PerformAction(out obj);
                    wordsTable.Rows.Add(obj.word_o, obj.Type.type_description, obj.word_m);
                    wordsTable.Sort(wordsTable.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                    MessageBox.Show("Add successfully");
                }
            };
            this.btnDelete.Click += BtnDelete_Click;
            this.wordsTable.CellDoubleClick += WordsTable_CellDoubleClick;
            this.btnSelect.Click += (sender, e) => SelectAllCheckBox(true);
            this.btnDeSelect.Click += (sender, e) => SelectAllCheckBox(false);
        }

        private void SelectAllCheckBox(bool @checked)
        {
            foreach (Control ctrl in wordListPanel.Controls)
            {
                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = @checked;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string word = wordsTable.SelectedRows[0].Cells[0].Value.ToString();
            string type = wordsTable.SelectedRows[0].Cells[1].Value.ToString();
            int id = manager.GetIDOfType(type);
            manager.RemoveWord(word, id);
            wordsTable.Rows.RemoveAt(wordsTable.SelectedRows[0].Index);
            MessageBox.Show("removed successfully");
        }

        private void WordsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string word = wordsTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            string type = wordsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            string mean = wordsTable.Rows[e.RowIndex].Cells[2].Value.ToString();

            FrmEdit_Add frm = new FrmEdit_Add(false, word, manager.GetIDOfType(type), mean);
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                Word obj;
                frm.PerformAction(out obj);
                wordsTable.Rows[e.RowIndex].Cells[2].Value = obj.word_m;
                MessageBox.Show("Edit successfully");
            }
        }

        private void RecmWordsList_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtSearch.TextChanged -= TxtSearch_TextChanged;
            this.txtSearch.Text = this.recmWordsList.Items[this.recmWordsList.IndexFromPoint(e.Location)].ToString();
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            ShowWordInfs(this.txtSearch.Text);
        }

        private void ShowWordInfs(string word)
        {
            this.txtMeans.Clear();
            this.txtMeans.AppendText(word + Environment.NewLine);
            this.txtMeans.SelectionStart = 0;
            this.txtMeans.SelectionLength = this.txtMeans.Lines[0].Length;
            this.txtMeans.SelectionColor = System.Drawing.Color.Purple;
            var data = manager.GetMeansOfWord(word);
            foreach (var type in data)
            {
                this.txtMeans.AppendText("    - " + manager.GetStringDescriptionOfTypeKey(type.Key));
                this.txtMeans.SelectionStart = this.txtMeans.GetFirstCharIndexOfCurrentLine();
                this.txtMeans.SelectionLength = this.txtMeans.Lines[this.txtMeans.GetLineFromCharIndex(this.txtMeans.SelectionStart)].Length;
                this.txtMeans.SelectionColor = System.Drawing.Color.Blue;
                this.txtMeans.AppendText(Environment.NewLine);
                foreach (var means in type)
                {
                    this.txtMeans.AppendText("        + " + means.word_m + Environment.NewLine);
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowRecommendWords(this.txtSearch.Text);
        }

        private void ShowRecommendWords(string text)
        {
            var dataSource = manager.GetDistinctWordsList();
            var data = dataSource.Where(item => item.ToLower().StartsWith(text.ToLower())).Select(item => item);
            this.recmWordsList.DataSource = data.ToList();
            this.recmWordsList.ClearSelected();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            LoadWordsToHintList();
            LoadWordsToManageList();
            LoadWordsToImExTab();
        }

        private void LoadWordsToImExTab()
        {
            var data = manager.GetDistinctWordsList();
            foreach (string item in data)
            {
                this.wordListPanel.Controls.Add(new CheckBox() { Checked = false, Text = item, Cursor = Cursors.Hand });
            }
        }

        private void LoadWordsToManageList()
        {
            var data = manager.GetWordsData();
            foreach (var item in data)
            {
                wordsTable.Rows.Add(item.word, item.type, item.mean);
            }
        }

        private void LoadWordsToHintList()
        {
            this.recmWordsList.DataSource = manager.GetDistinctWordsList();
            this.recmWordsList.ClearSelected();
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
