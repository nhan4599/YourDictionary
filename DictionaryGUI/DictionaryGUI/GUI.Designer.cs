using System.Windows.Forms;
using System.Drawing;

namespace DictionaryGUI
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSeparator = new TabControl();
            this.tabSearch = new TabPage();
            this.btnDel = new Button();
            this.btnPronounce = new Button();
            this.txtMeans = new RichTextBox();
            this.recmWordsList = new ListBox();
            this.txtSearch = new TextBox();
            this.btnFind = new Button();
            this.tabManage = new TabPage();
            this.wordsTable = new DataGridView();
            this.word = new DataGridViewTextBoxColumn();
            this.mean = new DataGridViewTextBoxColumn();
            this.pronounce = new DataGridViewButtonColumn();
            this.tabIm_Ex = new TabPage();
            this.boxExport = new GroupBox();
            this.btnDeSelect = new Button();
            this.btnSelect = new Button();
            this.wordListPanel = new FlowLayoutPanel();
            this.boxImport = new GroupBox();
            this.txtPath = new TextBox();
            this.lbPath = new Label();
            this.btnDirect = new Button();
            this.tabSeparator.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.txtMeans.SuspendLayout();
            this.tabManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsTable)).BeginInit();
            this.tabIm_Ex.SuspendLayout();
            this.boxExport.SuspendLayout();
            this.boxImport.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabSeparator
            // 
            this.tabSeparator.Controls.Add(this.tabSearch);
            this.tabSeparator.Controls.Add(this.tabManage);
            this.tabSeparator.Controls.Add(this.tabIm_Ex);
            this.tabSeparator.Location = new Point(1, 0);
            this.tabSeparator.Name = "tabSeparator";
            this.tabSeparator.SelectedIndex = 0;
            this.tabSeparator.Size = new Size(855, 418);
            this.tabSeparator.TabIndex = 0;

            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = Color.MintCream;
            this.tabSearch.Controls.Add(this.btnDel);
            this.tabSearch.Controls.Add(this.btnPronounce);
            this.tabSearch.Controls.Add(this.txtMeans);
            this.tabSearch.Controls.Add(this.recmWordsList);
            this.tabSearch.Controls.Add(this.txtSearch);
            this.tabSearch.Controls.Add(this.btnFind);
            this.tabSearch.Location = new Point(4, 25);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new Padding(3);
            this.tabSearch.Size = new Size(847, 389);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";

            // 
            // btnDel;
            // 
            this.btnDel.BackColor = Color.FromArgb(255, 106, 106);
            this.btnDel.BackgroundImageLayout = ImageLayout.None;
            this.btnDel.FlatStyle = FlatStyle.Popup;
            this.btnDel.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold);
            this.btnDel.ForeColor = SystemColors.ControlText;
            this.btnDel.Location = new Point(699, 50);
            this.btnDel.Name = "button2";
            this.btnDel.Size = new Size(93, 33);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;

            // 
            // btnPronounce
            // 
            this.btnPronounce.Image = Image.FromFile(
                @"D:\YourDictionary\DictionaryGUI\DictionaryGUI\Speaker.Jpg");
            this.btnPronounce.Location = new Point(280, 5);
            this.btnPronounce.Name = "btnPronounce";
            this.btnPronounce.Size = new Size(47, 37);
            this.btnPronounce.TabIndex = 12;
            this.btnPronounce.UseVisualStyleBackColor = true;

            // 
            // txtMeans
            // 
            this.txtMeans.Controls.Add(this.btnPronounce);
            this.txtMeans.Location = new Point(404, 108);
            this.txtMeans.Multiline = true;
            this.txtMeans.Name = "txtMeans";
            this.txtMeans.ReadOnly = true;
            this.txtMeans.Size = new Size(335, 230);
            this.txtMeans.TabIndex = 11;

            // 
            // recmWordsList
            // 
            this.recmWordsList.Location = new Point(55, 108);
            this.recmWordsList.Name = "recmWordsList";
            this.recmWordsList.Size = new Size(308, 230);
            this.recmWordsList.TabIndex = 10;

            // 
            // txtSearch
            // 
            this.txtSearch.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            this.txtSearch.Location = new Point(55, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(482, 28);
            this.txtSearch.TabIndex = 9;

            // 
            // btnFind
            // 
            this.btnFind.BackColor = Color.FromArgb(255, 106, 106);
            this.btnFind.BackgroundImageLayout = ImageLayout.None;
            this.btnFind.FlatStyle = FlatStyle.Popup;
            this.btnFind.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold);
            this.btnFind.ForeColor = SystemColors.ControlText;
            this.btnFind.Location = new Point(572, 50);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new Size(93, 33);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;

            // 
            // tabMange
            // 
            this.tabManage.BackColor = Color.MintCream;
            this.tabManage.Controls.Add(this.wordsTable);
            this.tabManage.Location = new Point(4, 25);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new Padding(3);
            this.tabManage.Size = new Size(847, 389);
            this.tabManage.TabIndex = 1;
            this.tabManage.Text = "Manage";

            // 
            // wordsTable
            // 
            this.wordsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.wordsTable.BackgroundColor = Color.Honeydew;
            this.wordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsTable.Columns.AddRange(new DataGridViewColumn[] {
            this.word,
            this.mean,
            this.pronounce});
            this.wordsTable.Location = new Point(37, 70);
            this.wordsTable.Name = "wordsTable";
            this.wordsTable.Size = new Size(774, 280);
            this.wordsTable.TabIndex = 0;

            // 
            // Word
            // 
            this.word.HeaderText = "Word";
            this.word.Name = "Word";

            // 
            // Mean
            // 
            this.mean.HeaderText = "Mean";
            this.mean.Name = "Mean";

            // 
            // Pronounce
            // 
            this.pronounce.HeaderText = "Pronounce";
            this.pronounce.Name = "Pronounce";

            // 
            // tabIm_Ex
            // 
            this.tabIm_Ex.BackColor = Color.MintCream;
            this.tabIm_Ex.Controls.Add(this.boxExport);
            this.tabIm_Ex.Controls.Add(this.boxImport);
            this.tabIm_Ex.Cursor = Cursors.Default;
            this.tabIm_Ex.Location = new Point(4, 25);
            this.tabIm_Ex.Name = "tabPage3";
            this.tabIm_Ex.Padding = new Padding(3);
            this.tabIm_Ex.Size = new Size(847, 389);
            this.tabIm_Ex.TabIndex = 2;
            this.tabIm_Ex.Text = "Import / Export";

            // 
            // boxImport
            // 
            this.boxImport.Location = new Point(61, 42);
            this.boxImport.Name = "boxImport";
            this.boxImport.Size = new Size(682, 59);
            this.boxImport.Controls.Add(this.lbPath);
            this.boxImport.Controls.Add(this.txtPath);
            this.boxImport.Controls.Add(this.btnDirect);
            this.boxImport.TabIndex = 0;
            this.boxImport.TabStop = false;
            this.boxImport.Text = "Import";

            // 
            // boxExport
            // 
            this.boxExport.Controls.Add(this.btnDeSelect);
            this.boxExport.Controls.Add(this.btnSelect);
            this.boxExport.Controls.Add(this.wordListPanel);
            this.boxExport.Location = new Point(61, 132);
            this.boxExport.Name = "boxExport";
            this.boxExport.Size = new Size(682, 226);
            this.boxExport.TabIndex = 1;
            this.boxExport.TabStop = false;
            this.boxExport.Text = "Export";

            // 
            // wordsListPanel
            // 
            this.wordListPanel.Location = new Point(42, 32);
            this.wordListPanel.Name = "wordListPanel";
            this.wordListPanel.Size = new Size(386, 171);
            this.wordListPanel.TabIndex = 0;

            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = Color.FromArgb(255, 106, 106);
            this.btnSelect.BackgroundImageLayout = ImageLayout.None;
            this.btnSelect.FlatStyle = FlatStyle.Popup;
            this.btnSelect.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold);
            this.btnSelect.ForeColor = SystemColors.ControlText;
            this.btnSelect.Location = new Point(434, 32);
            this.btnSelect.Name = "button4";
            this.btnSelect.Size = new Size(115, 33);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "Select all";
            this.btnSelect.UseVisualStyleBackColor = false;

            // 
            // btnDeSelect
            // 
            this.btnDeSelect.BackColor = Color.FromArgb(255, 106, 106);
            this.btnDeSelect.BackgroundImageLayout = ImageLayout.None;
            this.btnDeSelect.FlatStyle = FlatStyle.Popup;
            this.btnDeSelect.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold);
            this.btnDeSelect.ForeColor = SystemColors.ControlText;
            this.btnDeSelect.Location = new Point(555, 32);
            this.btnDeSelect.Name = "btnDeSelect";
            this.btnDeSelect.Size = new Size(111, 33);
            this.btnDeSelect.TabIndex = 10;
            this.btnDeSelect.Text = "Deselect all";
            this.btnDeSelect.UseVisualStyleBackColor = false;

            // 
            // textBox1
            // 
            this.txtPath.Location = new Point(95, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new Size(467, 22);
            this.txtPath.TabIndex = 0;

            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new Point(43, 24);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new Size(37, 17);
            this.lbPath.TabIndex = 1;
            this.lbPath.Text = "Path";
            this.lbPath.TextAlign = ContentAlignment.MiddleRight;

            // 
            // btnDirect
            // 
            this.btnDirect.Location = new Point(581, 19);
            this.btnDirect.Name = "btnDirect";
            this.btnDirect.Size = new Size(35, 23);
            this.btnDirect.TabIndex = 2;
            this.btnDirect.Text = "...";
            this.btnDirect.UseVisualStyleBackColor = true;

            // 
            // GUI
            // 
            this.ClientSize = new Size(858, 419);
            this.Controls.Add(this.tabSeparator);
            this.Name = "GUI";
            this.Text = "Your dictionary";
            this.tabSeparator.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.txtMeans.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordsTable)).EndInit();
            this.tabIm_Ex.ResumeLayout(false);
            this.boxExport.ResumeLayout(false);
            this.boxImport.ResumeLayout(false);
            this.boxImport.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private TabControl tabSeparator;
        private TabPage tabSearch, tabManage, tabIm_Ex;
        private Button btnPronounce, btnFind, btnDel, btnSelect, btnDeSelect, btnDirect;
        private RichTextBox txtMeans;
        private ListBox recmWordsList;
        private TextBox txtSearch, txtPath;
        private DataGridView wordsTable;
        private DataGridViewTextBoxColumn word, mean;
        private DataGridViewButtonColumn pronounce;
        private GroupBox boxImport, boxExport;
        private FlowLayoutPanel wordListPanel;
        private Label lbPath;
    }
}