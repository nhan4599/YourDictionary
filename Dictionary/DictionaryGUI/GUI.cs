using System;
using System.Windows.Forms;

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
