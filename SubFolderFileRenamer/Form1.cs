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
        static int totalFiles = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void b_Start_Click(object sender, EventArgs e)
        {
            RenameFolder(tb_Path.Text, tb_OldString.Text, tb_NewString.Text);
            MessageBox.Show("Done-TotalFiles:" + totalFiles);
        }
        static void RenameFolder(string folderName, string oldName, string newName)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderName);

            // Önce ALT klasörlerde işlem yap (yoksa üst klasörü değiştirince alt klasörü bulamazsın)
            foreach (var subDir in dirInfo.GetDirectories())
            {
                RenameFolder(subDir.FullName, oldName, newName);

                if (subDir.Name.Contains(oldName))
                {
                    string newSubDirName = Path.Combine(subDir.Parent.FullName, subDir.Name.Replace(oldName, newName));
                    if (!Directory.Exists(newSubDirName))
                    {
                        subDir.MoveTo(newSubDirName);
                    }
                }
            }

            // Dosyaları yeniden adlandır
            foreach (var file in dirInfo.GetFiles())
            {
                if (file.Name.Contains(oldName))
                {
                    string newFileName = Path.Combine(file.Directory.FullName, file.Name.Replace(oldName, newName));
                    if (!File.Exists(newFileName))
                    {
                        file.MoveTo(newFileName);
                    }
                }
            }
        }


    }
}
