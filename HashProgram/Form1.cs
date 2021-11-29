using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace HashProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SelectInputCB.SelectedIndex = 1; 
            setOpenFileDialog();
            
        }

        int choice = 0;

        private void SelectInputCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            choice = cb.SelectedIndex;
            switch (choice)
            {
                case 0:
                    InputTB.ReadOnly = false;
                    InputTB.Text = "";
                    break;
                case 1:
                    InputTB.ReadOnly = false;
                    InputTB.Text = "";
                    break;
                case 2:
                    binfilePath = openBinFile();
                    InputTB.ReadOnly = true;
                    break;

            }
        }

        private static string binfilePath = "";
        private string openBinFile()
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                InputTB.Text = ofd.FileName;
                return ofd.FileName;
            } else
            {
                return "";
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (isCheck())
            { 
                switch (choice)
                {
                    case 0:
                        byte[] inputBytes = Encoding.ASCII.GetBytes(InputTB.Text.ToString());
                        startHash(inputBytes);
                        break;
                    case 1:
                        if (OnlyHexInString(InputTB.Text.ToString()))
                        {
                            byte[] inputByte = Encoding.ASCII.GetBytes(hex2string(InputTB.Text.ToString()));
                            startHash(inputByte);
                        }
                        else
                        {
                            MessageBox.Show("Please enter correct HEX format.");
                        }
                        break;
                   case 2:
                        if (binfilePath != "")
                        {
                            byte[] input = File.ReadAllBytes(binfilePath);
                            startHash(input);
                        } else
                        {
                            MessageBox.Show("Plase select a file.");
                        }
                
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please choice at least 1 option.");
/*
                md5OutputTb.Text = "";
                sha1OutputTb.Text = "";
                sha1OutputTb.Text = "";
*/
                return;
            }

        }

        private bool isCheck()
        {
            if (!md5Cb.Checked && !sha1Cb.Checked && !sha2Cb.Checked) return false;
            return true;
        }

        private static bool OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        private void startHash(byte[] input)
        {

            if (md5Cb.Checked)
            {
                md5OutputTb.Text = md5HashCalculate(input);
            }

            if (sha1Cb.Checked)
            {
                sha1OutputTb.Text = sha1HashCalculate(input);
            }

            if (sha2Cb.Checked)
            {
                sha2OutputTb.Text = sha2HashCalculate(input);
            }
        }

        private void showValueBtn_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:
                    MessageBox.Show(InputTB.Text.ToString());
                    break;
            }
        }

        private static String hex2string(String hex) 
        {

            string ascii = string.Empty;
            for (int i = 0; i < hex.Length; i += 2) 
            {
                ascii += (char)HexadecimalToDecimal(hex.Substring(i, 2));

            }
            return ascii;
        }

        private static int HexadecimalToDecimal(string hex)
        {
            hex = hex.ToUpper();

            int hexLength = hex.Length;
            double dec = 0;

            for (int i = 0; i < hexLength; ++i)
            {
                byte b = (byte)hex[i];

                if (b >= 48 && b <= 57)
                    b -= 48;
                else if (b >= 65 && b <= 70)
                    b -= 55;

                dec += b * Math.Pow(16, ((hexLength - i) - 1));
            }

            return (int)dec;
        }

        private static String md5HashCalculate(byte[] inputBytes)
        {
            using (MD5 md5 = MD5.Create()) //  Creates an instance of the default implementation of the MD5 hash algorithm.
            {
                byte[] hahsBytes = md5.ComputeHash(inputBytes); // Computes the hash value for the specified byte array.

                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < hahsBytes.Length; i++)
                {
                    sb.Append(hahsBytes[i].ToString("X2"));
                }

                return sb.ToString().ToLower(); 

            }
        }

        private String sha1HashCalculate(byte [] inputBytes)
        {
            using(SHA1 sha1 = SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for(int  i= 0; i< hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        private String sha2HashCalculate(byte[] inputBytes)
        {
            using (SHA256 sha2 = SHA256.Create())
            {
                byte[] hashBytes = sha2.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        // Check hex string
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      


        private static OpenFileDialog ofd = new OpenFileDialog();

        private static void setOpenFileDialog()
        {
            ofd.InitialDirectory = @"C:\";
            //ofd.DefaultExt = "txt";
            ofd.RestoreDirectory = true;
            // Cấu trúc filter như sau: <tên file> (<đuôi file>)|<*.đuôi file>
            ofd.Filter = "txt files (*.txt)|*.txt|binary files (*.bin)|*bin|All files (*.*)|*.*";
            
            // ta có 3 cái filter, giả sử ta muốn mặc định mở ofd sẽ chọn filter thứ 3
            ofd.FilterIndex = 3;
            // Cho phép chọn nhiều file
            //ofd.Multiselect = true;


        }


      
        private static void createBinaryFile()
        {
            try
            {
                // file name
                string fileName = @"D:\info.bin";

                // Info
                string authorName = "Thanh Huy";
                int age = 20;
                string[] favoriteFood = new string[] { "Pho", "Mi", "Hu tieu" };
                bool isHandsome = true;
                double height = 1.79;

                /* BinaryWriter bwStream = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                 Encoding ascii = Encoding.ASCII;*/

                using (BinaryWriter binWriter = new BinaryWriter(new FileStream(fileName, FileMode.Create)))
                {
                    binWriter.Write(authorName);
                    binWriter.Write(age);
                    for (int i = 0; i < favoriteFood.Length; i++)
                    {
                        binWriter.Write(favoriteFood[i]);
                    }
                    binWriter.Write("Is handsome:" + isHandsome);
                    binWriter.Write(height);
                    MessageBox.Show("Write data successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Online MD5 tool
        //https://emn178.github.io/online-tools/md5_checksum.html
        //
        private void openBinaryBtn_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                MD5 mD5 = MD5.Create();

                FileStream fs = File.OpenRead(ofd.FileName);
                byte[] output = File.ReadAllBytes(ofd.FileName);
                byte[] outputBytes = mD5.ComputeHash(output);
                StringBuilder sb = new StringBuilder();

                for(int  i= 0;i < outputBytes.Length; i++)
                {
                    sb.Append(outputBytes[i].ToString("X2"));
                }
                binaryMd5Tb.Text = sb.ToString();
/*
                MD5 mD5 = MD5.Create();
                byte[] inputBytes = File.ReadAllBytes(ofd.FileName);
                byte[] outputBytes = mD5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for(int i=0;i < outputBytes.Length; i++)
                {
                    sb.Append(outputBytes[i].ToString("X2"));
                }

                binaryMd5Tb.Text = sb.ToString();
*/
            }
        }

        private void InputTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            InputTB.Text = "";
            md5OutputTb.Text = "";
            sha1OutputTb.Text = "";
            sha2OutputTb.Text = "";
        }
    }
}
