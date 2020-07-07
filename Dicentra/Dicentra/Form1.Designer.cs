namespace Dicentra
{
    partial class BrowserForm
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
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.newTabButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.urlBar = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.browser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.tab = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.controlsPanel.SuspendLayout();
            this.urlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browser)).BeginInit();
            this.tabsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlsPanel.Controls.Add(this.urlPanel);
            this.controlsPanel.Controls.Add(this.tabsPanel);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsPanel.Location = new System.Drawing.Point(0, 0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(800, 50);
            this.controlsPanel.TabIndex = 0;
            // 
            // urlPanel
            // 
            this.urlPanel.AutoSize = true;
            this.urlPanel.BackColor = System.Drawing.Color.Transparent;
            this.urlPanel.Controls.Add(this.newTabButton);
            this.urlPanel.Controls.Add(this.homeButton);
            this.urlPanel.Controls.Add(this.refreshButton);
            this.urlPanel.Controls.Add(this.forwardButton);
            this.urlPanel.Controls.Add(this.urlBar);
            this.urlPanel.Controls.Add(this.backButton);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.urlPanel.Location = new System.Drawing.Point(0, 21);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(800, 29);
            this.urlPanel.TabIndex = 1;
            // 
            // newTabButton
            // 
            this.newTabButton.FlatAppearance.BorderSize = 0;
            this.newTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newTabButton.Location = new System.Drawing.Point(167, 3);
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(35, 23);
            this.newTabButton.TabIndex = 5;
            this.newTabButton.Text = "＋";
            this.newTabButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.homeButton.Location = new System.Drawing.Point(126, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(35, 23);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "🏠";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homeButton_MouseDown);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.refreshButton.Location = new System.Drawing.Point(85, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(35, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "↺";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.FlatAppearance.BorderSize = 0;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.forwardButton.Location = new System.Drawing.Point(44, 3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(35, 23);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = "→";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // urlBar
            // 
            this.urlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.urlBar.Location = new System.Drawing.Point(205, 3);
            this.urlBar.Name = "urlBar";
            this.urlBar.Size = new System.Drawing.Size(592, 23);
            this.urlBar.TabIndex = 1;
            this.urlBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlBar_KeyDown);
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 50);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(800, 400);
            this.browser.Source = new System.Uri("https://google.com", System.UriKind.Absolute);
            this.browser.TabIndex = 1;
            this.browser.DOMContentLoaded += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs>(this.browser_DOMContentLoaded);
            this.browser.NavigationStarting += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs>(this.browser_NavigationStarting);
            // 
            // tab
            // 
            this.tab.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(130, 23);
            this.tab.TabIndex = 0;
            this.tab.Text = "New Tab";
            this.tab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(136, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Tab";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabsPanel
            // 
            this.tabsPanel.BackColor = System.Drawing.Color.Transparent;
            this.tabsPanel.Controls.Add(this.button1);
            this.tabsPanel.Controls.Add(this.tab);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabsPanel.Location = new System.Drawing.Point(0, 0);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Size = new System.Drawing.Size(800, 24);
            this.tabsPanel.TabIndex = 0;
            this.tabsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tabsPanel_Paint);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.controlsPanel);
            this.Name = "BrowserForm";
            this.Text = "Dicentra";
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browser)).EndInit();
            this.tabsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.TextBox urlBar;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button newTabButton;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView browser;
        private System.Windows.Forms.Panel tabsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tab;
    }
}

