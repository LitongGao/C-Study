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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripLabel1.Text = DateTime.Now.ToString();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string sourcePath = SourceFilePath.Text;
            string targetPath = TargetFilePath.Text;
            bool isOverWrite = chkOverWrite.Checked;
            VerifySpecialFile.IOAction.CopyFile(sourcePath, targetPath, !isOverWrite);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string targetPath = TargetFilePath.Text;
            string fileName = RemovedFileName.Text;
            VerifySpecialFile.IOAction.RemoveFile(targetPath, fileName);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {

        }
    }
}
