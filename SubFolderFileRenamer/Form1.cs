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

namespace SubFolderFileRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_Start_Click(object sender, EventArgs e)
        {
            RenameFolder(tb_Path.Text, tb_OldString.Text, tb_NewString.Text);

        }
        static void RenameFolder(string folderName, string oldName, string newName)
        {
            var totalFiles = Directory.GetFiles(folderName, "*.*", SearchOption.AllDirectories).Length;
            var currentFile = 0;
            DirectoryInfo dirInfo = new DirectoryInfo(folderName);

            // Rename subfolders
            foreach (var subDir in dirInfo.GetDirectories())
            {
                if (subDir.Name.Contains(oldName))
                {
                    string newSubDirName = Path.Combine(subDir.Parent.FullName, subDir.Name.Replace(oldName, newName));
                    subDir.MoveTo(newSubDirName);
                }
                RenameFolder(subDir.FullName, oldName, newName);
                currentFile++;
            }

            // Rename files
            foreach (var file in dirInfo.GetFiles())
            {
                if (file.Name.Contains(oldName))
                {
                    string newFileName = Path.Combine(file.Directory.FullName, file.Name.Replace(oldName, newName));
                    file.MoveTo(newFileName);
                }
                currentFile++;
            }
            MessageBox.Show("Done-" + currentFile);
        }

    }
}
