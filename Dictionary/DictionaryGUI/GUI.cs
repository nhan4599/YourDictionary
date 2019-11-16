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
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowrecommendWords(this.txtSearch.Text);
        }

        private void ShowrecommendWords(string text)
        {
            var dataSource = GetDistinctWordsList();
            var data = dataSource.Where(item => item.ToLower().StartsWith(text.ToLower())).Select(item => item);
            this.recmWordsList.DataSource = data.ToList();
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
