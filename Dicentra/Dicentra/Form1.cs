using Microsoft.Toolkit.Forms.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.AI.MachineLearning;

namespace Dicentra
{
    public partial class BrowserForm : Form
    {

        private String homeUrl = "https://google.com";          // URL of home page
        private int tabIndex = 0;                               // Index of currently selected tab
        private List<WebView> webViews = new List<WebView>();   // List of web views for each tab
        private WebView currentWebView = new WebView();         // Currently selected webview


        public BrowserForm()
        {
            InitializeComponent();

            // Add default web view to web views list
            webViews.Add(defaultWebView);

            // Assign current web view to default web view
            currentWebView = defaultWebView;
        }

        // Highlights home button or unhighlights it depending if the current page is the home page
        private void highlightHomeButton()
        {
            // Set color of home button to be highlighted when current page is home page
            if (currentWebView.Source.ToString() == homeUrl)
            {
                homeButton.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                homeButton.BackColor = System.Drawing.Color.Transparent;
            }
        }

        // Updates text of current tab, form title, and URL bar to match the content of the current web view
        private void updatePageTextInfo()
        {
            // Set form title to title of webpage
            this.Text = currentWebView.DocumentTitle;

            // Set text of url bar to be current page's title
            urlBar.Text = currentWebView.Source.ToString();

            // Unfocus url bar once content is loaded
            this.ActiveControl = null;

            // Change text of current tab to be the name of the current webview
            tabControl.SelectedTab.Text = currentWebView.DocumentTitle;

            highlightHomeButton();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            currentWebView.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            currentWebView.GoForward();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            currentWebView.Refresh();
        }

        private void homeButton_MouseDown(object sender, MouseEventArgs e)
        {
            // If user clicks with left mouse button, go to home page
            if (e.Button == MouseButtons.Left)
            {
                currentWebView.Navigate(homeUrl);
            }
            // If user clicks with right mouse button, set home page
            else if (e.Button == MouseButtons.Right)
            {
                homeUrl = currentWebView.Source.ToString();
                highlightHomeButton();
            }
        }

        private void urlBar_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user pressed enter, change browser url to what they typed
            if (e.KeyCode == Keys.Enter)
            {
                // Use Try/Catch to prevent crash on invalid URL
                try
                {
                    String urlBarText = urlBar.Text;

                    // If there is no HTTP or HTTPS protocol, add https protocol
                    if (!urlBarText.StartsWith("http://") && !urlBarText.StartsWith("https://"))
                    {
                        urlBarText = "https://" + urlBarText;
                    }

                    //Set url bar text to be the corrected url
                    urlBar.Text = urlBarText;

                    // Set browser URL to the validated text put into the URL bar
                    currentWebView.Navigate(urlBarText);

                }
                catch (Exception) { }
            }
        }

        // Handler for when webpage finishes loading
        private void browser_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e)
        {
            // Unfocus url bar once content is loaded
            this.ActiveControl = currentWebView;

            updatePageTextInfo();
        }

        private void browser_NavigationStarting(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs e)
        {
            // Set title of form and current tab to loading to indicate that the current page is loading
            this.Text = "Loading...";
            tabControl.SelectedTab.Text = "Loading...";

        }

        private void tabsPanel_Paint(object sender, PaintEventArgs e) {}

        // Handler for adding a new tab to browser.
        private void newTabButton_Click(object sender, EventArgs e)
        {
            // Create new webview and set its settings
            WebView newWebView = new WebView();
            newWebView.Source = new Uri(homeUrl);
            newWebView.Dock = DockStyle.Fill;

            // Add event handlers to new webview
            newWebView.NavigationCompleted += new EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(browser_NavigationCompleted);
            newWebView.NavigationStarting += new EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs>(browser_NavigationStarting);
            newWebView.DOMContentLoaded += new EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs>(browser_DOMContentLoaded);

            // Add the new web view to the web view list
            webViews.Add(newWebView);

            // Add and select a new tab to the tab control
            TabPage newTabPage = new TabPage("New Tab");
            tabControl.TabPages.Add(newTabPage);
            tabControl.SelectedTab = newTabPage;

            // Change tab index to correspond to selected index of tab control
            tabIndex = tabControl.SelectedIndex;

            // Add the new tab web view and bring it to the front
            this.Controls.Add(newWebView);
            newWebView.BringToFront();
        }

        // Handler for when user changes tabs
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update tab index
            tabIndex = tabControl.SelectedIndex;

            // Update current web view when user changes tab
            currentWebView = webViews.ElementAt(tabIndex);

            // Bring webview up front depending on which tab user selected
            currentWebView.BringToFront();

            // Update page text  info when tab has been changed
            updatePageTextInfo();
        }

        // Once page nagivation has started, update page text info
        private void browser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            updatePageTextInfo();
        }

        // Handler for when form is closed
        private void BrowserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Go through each webview and destroy it
            foreach (WebView webView in webViews)
            {
                // Stop all navigation and downloads and then dispose the web view
                webView.Stop();
                webView.Dispose();
            }
        }
    }
}
