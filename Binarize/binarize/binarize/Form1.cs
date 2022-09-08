using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace binarize
{
    public partial class Form1 : Form
    {

        string defaultBPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        byte[] bytes;
        int numBytesToRead;

        public Form1()
        {
            InitializeComponent();
        }

        private void fileSelect_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            OpenFileDialog browseFiles = new OpenFileDialog();

            browseFiles.InitialDirectory = "c:\\";
            browseFiles.RestoreDirectory = true;

            if (browseFiles.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = browseFiles.OpenFile()) != null)
                    {
                        using (fileStream)
                        {
                            // Insert code to read the stream here.
                            // Read the source file into a byte array.
                            bytes = new byte[fileStream.Length];
                            numBytesToRead = (int)fileStream.Length;
                            int numBytesRead = 0;
                            while (numBytesToRead > 0)
                            {
                                // Read may return anything from 0 to numBytesToRead.
                                int n = fileStream.Read(bytes, numBytesRead, numBytesToRead);

                                // Break when the end of the file is reached.
                                if (n == 0)
                                    break;

                                numBytesRead += n;
                                numBytesToRead -= n;
                            }
                            numBytesToRead = bytes.Length;
                        }

                        MessageBox.Show("File opened.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void binarize_Click(object sender, EventArgs e)
        {
            // Write the byte array to the other FileStream.
            /*using (FileStream binFile = new FileStream(defaultBPath,
                FileMode.Create, FileAccess.Write))
            {
                binFile.Write(bytes, 0, numBytesToRead);
            }*/

            string[] strbytes = new string[bytes.Length];
            //strbytes = ToString(bytes);

            foreach (byte octounet in bytes)
            {
                strbytes[octounet] = bytes[octounet].ToString();
            }

            File.Create("E:\\");
            TextWriter tw = new StreamWriter("E:\\");
            tw.WriteLine(bytes);
            //string[] strBytes = bytes;
            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", strbytes);
            tw.Close();
        }
    }
}
