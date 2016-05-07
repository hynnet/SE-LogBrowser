using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SE_LogBrowser.Utils;

namespace SE_LogBrowser
{
    public partial class MainWindow : Form
    {
        FileHelper fileHelper = new FileHelper();
        string logFile = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLoadFile_Click(object sender, EventArgs e)
        {
            logFile = fileHelper.OpenFileSelect();
            TextBoxLogParseResults.Text = logFile;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxLogParseResults.Text = "";
            logFile = "";
        }
    }
}
