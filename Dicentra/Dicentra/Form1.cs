using Microsoft.Toolkit.Forms.UI.Controls;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Windows.AI.MachineLearning;
using Windows.UI.WebUI;

namespace Dicentra
{
    public partial class BrowserForm : Form
    {
        private const int CLOSE_TAB_BUTTON_SIZE = 15;           // Size of close tab button hitbox
        private const int CONTROLS_HITBOX_SIZE = 30;            // Size of controls hover hitbox

        private List<WebView> webViews = new List<WebView>();   // List of web views for each tab
        private WebView currentWebView = new WebView();         // Currently selected webview

        private int previousTabIndex = 0;                       // Index of previous tab
        private int tabIndex = 0;                               // Index of currently selected tab
        
        private bool isFullScreen = false;                      // Flag that keeps track of whether or not window is fullscreen

        private String homeUrl = "https://google.com";          // URL of home page
        private String searchUrl = "https://google.com";        // URL of default search engine

        private Timer inputTimer = new Timer();                 // Timer used to get inputs for controls that don't support mouse/key events

        public BrowserForm()
        {
            InitializeComponent();

            // Add default web view to web views list
            webViews.Add(defaultWebView);

            // Assign current web view to default web view
            currentWebView = defaultWebView;

            inputTimer.Tick += inputTickHandler;
            inputTimer.Start();
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

        // Handler for when stop button is clicked.
        private void stopButton_Click(object sender, EventArgs e)
        {
            currentWebView.Stop();
        }

        // Handler for when the full screen button is clicked.
        private void fullscreenButton_Click(object sender, EventArgs e)
        {
            LogicHelper.toggleFullScreen(this, controlsPanel, ref isFullScreen);
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
                LogicHelper.highlightHomeButton(currentWebView, homeButton, homeUrl);
            }
        }

        private void urlBar_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user pressed enter, change browser url to what they typed
            if (e.KeyCode == Keys.Enter)
            {
                // Get text from URL bar
                String urlBarText = urlBar.Text;

                // Use Try/Catch to prevent crash on invalid URL
                try
                {
                    String formattedURL = urlBarText;   // Variable to hold URL input with added protocol if none was added originally

                    // If there is no HTTP or HTTPS protocol, add https protocol
                    if (!urlBarText.StartsWith("http://") && !urlBarText.StartsWith("https://"))
                    {
                        formattedURL = "https://" + urlBarText;
                    }

                    // Try to create a new URI object using URL bar input; throws exception if invalid
                    new Uri(formattedURL);

                    //Set url bar text to be the corrected url
                    urlBar.Text = formattedURL;

                    // Set browser URL to the validated text put into the URL bar
                    currentWebView.Navigate(formattedURL);

                }
                // If URL cannot be resolved, send text to google search
                catch (Exception) 
                {
                    currentWebView.Navigate(searchUrl + "/search?q=" + urlBarText);
                }
            }
        }

        // Handler for when webpage finishes loading
        private void browser_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e)
        {
            // Unfocus url bar once content is loaded
            this.ActiveControl = currentWebView;

            LogicHelper.updatePageTextInfo(this, (WebView)sender, webViews.IndexOf((WebView)sender), urlBar, tabControl, homeButton, homeUrl); ;
        }

        private void browser_NavigationStarting(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs e)
        {
            // Set title of form and current tab to loading to indicate that the current page is loading
            this.Text = "Loading... ❌";
            tabControl.SelectedTab.Text = "Loading... ❌";
        }

        // Once page nagivation has started, update page text info
        private void browser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            LogicHelper.updatePageTextInfo(this, (WebView) sender, webViews.IndexOf((WebView)sender), urlBar, tabControl, homeButton, homeUrl);
        }

        // Event handler for when a full screen element was changed in the browser (e.g. a YouTube video was set to full screen)
        private void browser_ContainsFullScreenElementChanged(object sender, object e)
        {
            LogicHelper.toggleFullScreen(this, controlsPanel,ref isFullScreen);
        }

        private void tabsPanel_Paint(object sender, PaintEventArgs e) {}

        // Handler for adding a new tab to browser.
        private void newTabButton_Click(object sender, EventArgs e)
        {
            // Add a new tab to the tab control
            TabPage newTabPage = new TabPage("New Tab ❌");
            tabControl.TabPages.Add(newTabPage);

            // Create new webview and set its settings
            WebView newWebView = new WebView();
            newWebView.Source = new Uri(homeUrl);
            newWebView.Dock = DockStyle.Fill;
            newWebView.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Add event handlers to new webview
            newWebView.NavigationCompleted += new EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(browser_NavigationCompleted);
            newWebView.NavigationStarting += new EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs>(browser_NavigationStarting);
            newWebView.DOMContentLoaded += new EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs>(browser_DOMContentLoaded);

            // Add the new web view to the web view list
            webViews.Add(newWebView);

            // Select the new tab
            tabControl.SelectedTab = newTabPage;

            // Change tab index to correspond to selected index of tab control
            previousTabIndex = tabIndex;
            tabIndex = tabControl.SelectedIndex;

            // Add the new tab web view and bring it to the front
            this.Controls.Add(newWebView);
            newWebView.BringToFront();
        }

        // Handler for when user changes tabs
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update tab index
            previousTabIndex = tabIndex;
            tabIndex = tabControl.SelectedIndex;

            // If user tries to remove the last tab, the selected tab should move right
            if (tabIndex < 0)
            {
                tabIndex = 0;
            }

            // Update current web view when user changes tab
            currentWebView = webViews.ElementAt(tabIndex);

            // Bring webview up front depending on which tab user selected
            currentWebView.BringToFront();

            // Update page text  info when tab has been changed
            LogicHelper.updatePageTextInfo(this, currentWebView, webViews.IndexOf(currentWebView), urlBar, tabControl, homeButton, homeUrl);
        }

        // Handler for when user clicks on tab control (used for detecting click to close tab)
        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            // Get rectangle of selected tab
            Rectangle selectedTabRectangle = tabControl.GetTabRect(tabControl.SelectedIndex);

            // Define hitbox of close tab button
            Rectangle closeTabButtonHitbox = new Rectangle(selectedTabRectangle.Right - CLOSE_TAB_BUTTON_SIZE, selectedTabRectangle.Top, CLOSE_TAB_BUTTON_SIZE, CLOSE_TAB_BUTTON_SIZE);

            // Check to see if user clicked in hitbox of close tab button
            if (closeTabButtonHitbox.Contains(e.Location))
            {
                // Get the web view to destroy
                WebView webViewToDestroy = webViews.ElementAt(tabControl.SelectedIndex);

                // Get the tab to close
                TabPage tabToClose = tabControl.SelectedTab;

                tabControl.SelectedIndex -= 1;
                

                // Remove tab from tab controls
                tabControl.TabPages.Remove(tabToClose);

                // Remove targeted webview from webview list and destroy it
                webViews.Remove(webViewToDestroy);
                LogicHelper.destroyWebView(webViewToDestroy);
                this.Controls.Remove(webViewToDestroy);

                // If user removed the last tab, close the form
                if (webViews.Count == 0)
                {
                    this.Dispose();
                    this.Close();
                    return;
                }

                // Update site info text
                LogicHelper.updatePageTextInfo(this, currentWebView, webViews.IndexOf(currentWebView), urlBar, tabControl, homeButton, homeUrl);

                // Change current web view to be the newly selected tab
                currentWebView = webViews.ElementAt(tabIndex);
            }
        }

        // Handler for when form is closed
        private void BrowserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Go through each webview and destroy it
            foreach (WebView webView in webViews)
            {
                LogicHelper.destroyWebView(webView);
            }
        }

        private void inputTickHandler(object sender, EventArgs e)
        {
            // Only check for hover if form is full screen
            if (isFullScreen)
            {
                // Create hitbox for where user can hover to re-show controls when in full screen
                Rectangle controlsHoverHitbox = this.RectangleToScreen(new Rectangle(0, 0, this.Width, 50));

                // Check to see if user's mouse is within the controls hover hitbox
                if (controlsHoverHitbox.Contains(Cursor.Position))
                {
                    // Show controls panel if user hovers in right location
                    controlsPanel.Visible = true;
                }
                else
                {
                    // Hide control panel if user moves mouse outside hitbox area
                    controlsPanel.Visible = false;
                }
            }
        }
    }
}
