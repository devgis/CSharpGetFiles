using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetFileList
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fbd.SelectedPath;
            }
        }
        List<string> listFileList = null;

        private void btSaveFileList_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbPath.Text))
            {
                //遍历下面得文件
                if (listFileList == null)
                {
                    listFileList = new List<string>();
                }
                else if (listFileList.Count > 0)
                {
                    listFileList.Clear();
                }

                GetFileList(tbPath.Text);

                StringBuilder sbList = new StringBuilder();
                foreach (string stemp in listFileList)
                {
                    sbList.AppendLine(stemp);
                }
                MessageBox.Show(sbList.ToString());
            }
            else
            {
                MessageBox.Show("文件夹不存在！");
            }
        }

        private void GetFileList(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                // 是文件
                listFileList.Add(FilePath);
            }
            else if (Directory.Exists(FilePath))
            {
                //遍历文件
                foreach (string sFile in Directory.GetFiles(FilePath))
                {
                    GetFileList(sFile);
                }

                //遍历文件夹
                foreach (string sPath in Directory.GetDirectories(FilePath))
                {
                    GetFileList(sPath);
                }
            }
            else
            {
                // 都不是
            }
        }
    }
}
