using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;



namespace Installer
{
    public partial class Form1 : Form
    {

        /*Процедура копирования директорий*/
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            if (Directory.Exists(destDirName)) Directory.Delete(destDirName, true);


            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);


            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            //string[] Drives = Environment.GetLogicalDrives();
            //foreach (string s in Drives)
            //{
            //    comboBox1.Items.Add(s);
            //}

            ManagementObjectSearcher searcher =
              new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject info in searcher.Get())
            {
                //TreeNode node = trvInfo.Nodes.Add(info["DeviceID"].ToString());
                //node.Nodes.Add("Model: " + info["Model"].ToString());
                //node.Nodes.Add("Interface: " + info["InterfaceType"].ToString());
                //node.Nodes.Add("Serial#: " + info["SerialNumber"].ToString());

                comboBox1.Items.Add(info["DeviceID"].ToString()+info["SerialNumber"].ToString());
            }

            //string[] Drives = Environment.GetLogicalDrives();
            //foreach (string s in Drives)
            //{
            //    comboBox_logical.Items.Add(s);
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ManagementObjectSearcher searcher =
              new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject info in searcher.Get())
            {
                if (info["DeviceID"].ToString() + info["SerialNumber"].ToString() == comboBox1.Text)
                {
                    DeviceID.Text = info["DeviceID"].ToString();
                    Serial_Number.Text = info["SerialNumber"].ToString();
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Setup_Click(object sender, EventArgs e)
        {
            string text="";
            /*Создаем зашифрованный серийный нмоер устройства*/
            for (int i = 1; i < Serial_Number.Text.Length; i+=2)
                text += Serial_Number.Text[i];
            for (int i = Serial_Number.Text.Length-2+ Serial_Number.Text.Length%2; i >=0; i -= 2)
                text += Serial_Number.Text[i];




            /*Создаем первый секретный файл с номером диска*/
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Program\\MyProgram\\VerySecureFolder\\BaskovMusic\\Караоке.mp3", false, System.Text.Encoding.Default))
            {
                sw.Write(text);
            }

            /*Создаем второй секретный файл с номером диска*/
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Program\\MyProgram\\ParProgLab3_1\\ParProgLab3_1\\bin\\obj.dll", false, System.Text.Encoding.Default))
            {
                sw.Write(text);
            }
            /*Расшифрованный из файлов серийный номер, чтобы проверить успешность записи*/
            label_test.Text = "";

            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Program\\MyProgram\\VerySecureFolder\\BaskovMusic\\Караоке.mp3", System.Text.Encoding.Default))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim(' ');
                    for (int i = line.Length - 1; i >= line.Length / 2 + line.Length % 2; i--)
                    {
                        char char1 = line[i];
                        char char2 = line[line.Length - i - 1];
                    label_test.Text += line[i]; 
                    label_test.Text += line[line.Length - i - 1];
                    }
                    if (line.Length % 2 == 1) label_test.Text += line[line.Length / 2];

                }
            }

            DirectoryCopy(AppDomain.CurrentDomain.BaseDirectory + "Program", textBox1.Text+"InfoBezLab2", true);

            if (label_test.Text == Serial_Number.Text.Trim(' ')) label_test.Text = "Привязка адреса прошла успешно!";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_logical_SelectedIndexChanged(object sender, EventArgs e)
        {
            logpath.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
