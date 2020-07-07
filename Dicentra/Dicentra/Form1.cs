using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicentra
{
    public partial class BrowserForm : Form
    {

        private String homeUrl = "https://google.com";  // URL of home page

        public BrowserForm()
        {
            InitializeComponent();
        }

        // Highlights home button or unhighlights it depending if the current page is the home page
        private void highlightHomeButton()
        {
            // Set color of home button to be highlighted when current page is home page
            if (browser.Source.ToString() == homeUrl)
            {
                homeButton.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                homeButton.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }

        private void homeButton_MouseDown(object sender, MouseEventArgs e)
        {
            // If user clicks with left mouse button, go to home page
            if (e.Button == MouseButtons.Left)
            {
                browser.Navigate(homeUrl);
            }
            // If user clicks with right mouse button, set home page
            else if (e.Button == MouseButtons.Right)
            {
                homeUrl = browser.Source.ToString();
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
                    browser.Navigate(urlBarText);

                }
                catch (Exception) { }
            }
        }

        private void browser_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e)
        {
            // Set form title to title of webpage
            this.Text = browser.DocumentTitle;

            // Set text of url bar to be current page's title
            urlBar.Text = browser.Source.ToString();

            // Unfocus url bar once content is loaded
            this.ActiveControl = null;

            highlightHomeButton();
        }

        private void browser_NavigationStarting(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs e)
        {
            // Set title to loading to indicate that the current page is loading
            this.Text = "Loading...";
        }

        private void tabsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
