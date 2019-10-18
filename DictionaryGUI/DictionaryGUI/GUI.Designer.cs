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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.tabManager = new System.Windows.Forms.TabPage();
            this.split = new System.Windows.Forms.SplitContainer();
            this.tabs.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.SuspendLayout();
            this.SuspendLayout();

            //
            // Split
            //
            this.split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split.Orientation = System.Windows.Forms.Orientation.Horizontal;

            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabSearch);
            this.tabs.Controls.Add(this.tabManager);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(600, 600);
            this.tabs.TabIndex = 0;

            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.split);
            this.tabSearch.Location = new System.Drawing.Point(4, 25);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(592, 571);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;

            // 
            // tabManager
            // 
            this.tabManager.Location = new System.Drawing.Point(4, 25);
            this.tabManager.Name = "tabManager";
            this.tabManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabManager.Size = new System.Drawing.Size(592, 571);
            this.tabManager.TabIndex = 1;
            this.tabManager.Text = "Manager Word";
            this.tabManager.UseVisualStyleBackColor = true;

            // 
            // splitContainer1
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(3, 3);
            this.split.Name = "splitContainer1";
            this.split.Size = new System.Drawing.Size(586, 565);
            this.split.SplitterDistance = 195;
            this.split.TabIndex = 0;

            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "GUI";
            this.Text = "My Dictionary";
            this.tabs.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabManager;
        private System.Windows.Forms.SplitContainer split;
    }
}

