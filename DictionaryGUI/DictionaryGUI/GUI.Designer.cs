using System.Drawing;
using System.Windows.Forms;

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
            this.tabs = new TabControl();
            this.tabSearch = new TabPage();
            this.tabManager = new TabPage();
            this.pnlTop = new Panel();
            this.split = new SplitContainer();
            this.tabs.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabSearch);
            this.tabs.Controls.Add(this.tabManager);
            this.tabs.Location = new Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new Size(600, 600);
            this.tabs.TabIndex = 0;

            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.split);
            this.tabSearch.Controls.Add(this.pnlTop);
            this.tabSearch.Location = new Point(4, 25);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new Padding(3);
            this.tabSearch.Size = new Size(592, 571);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;

            // 
            // tabManager
            // 
            this.tabManager.Location = new Point(4, 25);
            this.tabManager.Name = "tabManager";
            this.tabManager.Padding = new Padding(3);
            this.tabManager.Size = new Size(592, 571);
            this.tabManager.TabIndex = 1;
            this.tabManager.Text = "Manager Word";
            this.tabManager.UseVisualStyleBackColor = true;

            // 
            // panel1
            // 
            this.pnlTop.BorderStyle = BorderStyle.FixedSingle;
            this.pnlTop.Location = new Point(0, 0);
            this.pnlTop.Name = "panel1";
            this.pnlTop.Size = new Size(596, 74);
            this.pnlTop.TabIndex = 0;

            // 
            // splitContainer1
            // 
            this.split.Location = new Point(0, 74);
            this.split.Name = "splitContainer1";
            this.split.Size = new Size(592, 497);
            this.split.SplitterDistance = 197;
            this.split.TabIndex = 1;

            // 
            // GUI
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 600);
            this.Controls.Add(this.tabs);
            this.Margin = new Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Name = "GUI";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "My Dictionary";
            this.tabs.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private TabControl tabs;
        private TabPage tabSearch;
        private TabPage tabManager;
        private SplitContainer split;
        private Panel pnlTop;
    }
}

