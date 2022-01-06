using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webview_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }

        async Task InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        async void InitBrowser()
        {
            await InitializeAsync();
            webView21.CoreWebView2.Navigate("https://www.html5test.com");
        }
    }
}
