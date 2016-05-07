using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE_LogBrowser.Utils
{
    class FileHelper
    {
        public string OpenFileSelect()
        {
            OpenFileDialog dialog = SetupFileSelectDialog();
            DialogResult result = dialog.ShowDialog();
            string text = "";

            if (result == DialogResult.OK)
            {
                string file = dialog.FileName;

                try
                {
                    text = File.ReadAllText(file);
                }
                catch (IOException e)
                { }
            }

            return text;
        }

        public OpenFileDialog SetupFileSelectDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Select Packet Log File";
            dialog.Filter = "SoftEther Packet Log|*.log";

            return dialog;
        }
    }
}
