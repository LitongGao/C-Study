using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownLoadFileTool
{
    public partial class ShowFiles : Form
    {
        public ShowFiles()
        {
            InitializeComponent();
            this.TargetFilePath.Click += new System.EventHandler(this.TargetFilePath_Click);
        }

        private void SourceFilePath_Click(object sender, EventArgs e)
        {

        }

        private void TargetFilePath_Click(object sender, EventArgs e)
        {
            

        }

        private void btnShowFileT_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string targetPath = f1.TargetFilePath.Text;
            string[] files = VerifySpecialFile.IOAction.ShowFile(@"E:\Logs\copy");
            foreach (string file in files)
            {
                txbForT.Text += file + "\r\n";
            }
        }
    }
}
