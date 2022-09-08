using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace I_Fill_You
{
    public partial class MCQ_Filler : Form
    {
        public MCQ_Filler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            string myPath = @"E:\filler.xlsx";
            excelApp.Workbooks.Open(myPath);
            int rowIndex = 1; int colIndex = 1;

            excelApp.Cells[rowIndex, colIndex] = "First";
            excelApp.Visible = true;
        }

        OpenFileDialog quizzFile = new OpenFileDialog();
        private void fichier_Click(object sender, EventArgs e)
        {
            //DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            quizzFile.ShowDialog();
        }
    }
}
