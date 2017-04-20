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
            InitButtonTooltip();
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
            string targetPath = TargetFilePath.Text;
            VerifySpecialFile.IOAction.RemoveFile(targetPath);
        }

        private void InitButtonTooltip()
        {
            ToolTip toolTipForm1 = new ToolTip();
            toolTipForm1.SetToolTip(btnRemove, "Remove file you in input in the 'Remove textbox' from 'Target file path'");
            toolTipForm1.SetToolTip(btnRemoveAll, "Will remove all files and folder from 'Target file path'");
            toolTipForm1.SetToolTip(btnDownload, "Please input source file path and target file path");
            toolTipForm1.SetToolTip(chkOverWrite, "If you don't replace exist file, please check it");
        }

        private void btnShowFiles_Click(object sender, EventArgs e)
        {
            ShowFiles sf = new ShowFiles();
            sf.Show();
        }
    }
}
