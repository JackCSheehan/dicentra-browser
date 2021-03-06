﻿namespace Dicentra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.newTabButton = new System.Windows.Forms.Button();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.fullscreenButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.urlBar = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.defaultWebView = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.controlsPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.urlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlsPanel.Controls.Add(this.tabControl);
            this.controlsPanel.Controls.Add(this.newTabButton);
            this.controlsPanel.Controls.Add(this.urlPanel);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsPanel.Location = new System.Drawing.Point(0, 0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(800, 54);
            this.controlsPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl.Location = new System.Drawing.Point(44, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(715, 22);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Tab ❌";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // newTabButton
            // 
            this.newTabButton.FlatAppearance.BorderSize = 0;
            this.newTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newTabButton.Location = new System.Drawing.Point(3, 0);
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(35, 25);
            this.newTabButton.TabIndex = 5;
            this.newTabButton.Text = "＋";
            this.toolTip.SetToolTip(this.newTabButton, "New Tab");
            this.newTabButton.UseVisualStyleBackColor = true;
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // urlPanel
            // 
            this.urlPanel.AutoSize = true;
            this.urlPanel.BackColor = System.Drawing.Color.Transparent;
            this.urlPanel.Controls.Add(this.fullscreenButton);
            this.urlPanel.Controls.Add(this.stopButton);
            this.urlPanel.Controls.Add(this.urlBar);
            this.urlPanel.Controls.Add(this.homeButton);
            this.urlPanel.Controls.Add(this.refreshButton);
            this.urlPanel.Controls.Add(this.forwardButton);
            this.urlPanel.Controls.Add(this.backButton);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.urlPanel.Location = new System.Drawing.Point(0, 23);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(800, 31);
            this.urlPanel.TabIndex = 1;
            // 
            // fullscreenButton
            // 
            this.fullscreenButton.FlatAppearance.BorderSize = 0;
            this.fullscreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullscreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fullscreenButton.Location = new System.Drawing.Point(208, 3);
            this.fullscreenButton.Name = "fullscreenButton";
            this.fullscreenButton.Size = new System.Drawing.Size(35, 25);
            this.fullscreenButton.TabIndex = 8;
            this.fullscreenButton.Text = "⛶";
            this.toolTip.SetToolTip(this.fullscreenButton, "Full Screen");
            this.fullscreenButton.UseVisualStyleBackColor = true;
            this.fullscreenButton.Click += new System.EventHandler(this.fullscreenButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.stopButton.Location = new System.Drawing.Point(126, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(35, 25);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "x";
            this.toolTip.SetToolTip(this.stopButton, "Stop");
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // urlBar
            // 
            this.urlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBar.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February"});
            this.urlBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.urlBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.urlBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.urlBar.Location = new System.Drawing.Point(249, 5);
            this.urlBar.Name = "urlBar";
            this.urlBar.Size = new System.Drawing.Size(547, 23);
            this.urlBar.TabIndex = 6;
            this.toolTip.SetToolTip(this.urlBar, "URL or Search Query");
            this.urlBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlBar_KeyDown);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.homeButton.Location = new System.Drawing.Point(167, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(35, 25);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "🏠";
            this.toolTip.SetToolTip(this.homeButton, "Home");
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
            this.refreshButton.Size = new System.Drawing.Size(35, 25);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "↺";
            this.toolTip.SetToolTip(this.refreshButton, "Refresh");
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
            this.forwardButton.Size = new System.Drawing.Size(35, 25);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = "→";
            this.toolTip.SetToolTip(this.forwardButton, "Forward");
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 25);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "←";
            this.toolTip.SetToolTip(this.backButton, "Back");
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // defaultWebView
            // 
            this.defaultWebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultWebView.Location = new System.Drawing.Point(0, 54);
            this.defaultWebView.MinimumSize = new System.Drawing.Size(20, 22);
            this.defaultWebView.Name = "defaultWebView";
            this.defaultWebView.Size = new System.Drawing.Size(800, 431);
            this.defaultWebView.Source = new System.Uri("https://google.com", System.UriKind.Absolute);
            this.defaultWebView.TabIndex = 1;
            this.defaultWebView.ContainsFullScreenElementChanged += new System.EventHandler<object>(this.browser_ContainsFullScreenElementChanged);
            this.defaultWebView.DOMContentLoaded += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs>(this.browser_DOMContentLoaded);
            this.defaultWebView.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.browser_NavigationCompleted);
            this.defaultWebView.NavigationStarting += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs>(this.browser_NavigationStarting);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.defaultWebView);
            this.Controls.Add(this.controlsPanel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BrowserForm";
            this.Text = "Dicentra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrowserForm_FormClosed);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.TextBox rlBar;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button newTabButton;
        private System.Windows.Forms.TextBox urlBar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView defaultWebView;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button fullscreenButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

