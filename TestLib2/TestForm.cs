using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace TestLib2
{
  public partial class TestForm : Form
  {
    public TestForm()
    {
      InitializeComponent();
      Load += Form1_Load;
    }

    private ChromiumWebBrowser _webBrowser;

    private void Form1_Load(object sender, EventArgs e)
    {
      _webBrowser =
        new ChromiumWebBrowser(Path.Combine(Environment.CurrentDirectory, "html/index.html")) {Dock = DockStyle.Fill};
      Controls.Add(_webBrowser);
    }
  }
}