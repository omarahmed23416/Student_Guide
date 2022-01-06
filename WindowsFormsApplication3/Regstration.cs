using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApplication3
{
    public partial class Regstration : UserControl
    {
        Excel.Application oXL;
        Microsoft.Office.Interop.Excel._Workbook oWB;
        Microsoft.Office.Interop.Excel._Worksheet oSheet;
        Microsoft.Office.Interop.Excel.Range oRng;
        object misvalue = System.Reflection.Missing.Value;
        public Regstration()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Basic Science";
            oXL = new Excel.Application();
            oWB = (Excel._Workbook)(oXL.Workbooks.Add(""));
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = (string)comboBox1.SelectedItem;
            ClearAllSelections();
            if (comboBox1.SelectedItem == "Architectural Engineering")
                architectural1.BringToFront();
            else if (comboBox1.SelectedItem == "Civil Engineering")
                civil1.BringToFront();
            else if (comboBox1.SelectedItem == "Communications Engineering")
                communication1.BringToFront();
            else if (comboBox1.SelectedItem == "Basic Science")
                basic1.BringToFront();
        }
        public void ClearAllSelections()
        {
            Program.list = null;
            listBox1.Items.Clear();
            architectural1.Clear();
            civil1.Clear();
            communication1.Clear();
            basic1.Clear();
        }
        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.form.BringWait();
            button2_Click(null, null);
            saveFileDialog1.FileName = "Courses Selected" + count;
            oXL = new Excel.Application();
            oWB = (Excel._Workbook)(oXL.Workbooks.Add(""));
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            Form1.form.Opacity = .95;
            try
            {
                oSheet.Cells[1, 1] = "Code";
                oSheet.Cells[1, 2] = "Courses";
                oSheet.Cells[1, 3] = "Credit Hours";
                oSheet.Cells[1, 4] = "Prerequisite";
                oSheet.Cells.Font.Size = "18";
                oSheet.Cells.Font.Color = Excel.XlRgbColor.rgbWhite;
                oSheet.Cells.Font.Bold = true;
                oSheet.get_Range("A1", "D1").Style.HorizontalAlignment =
                Excel.XlHAlign.xlHAlignCenter;
                oSheet.get_Range("A1", "D1").Font.Size = "22";
                oSheet.get_Range("A1", "D1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("A1", "D1").ColumnWidth = "25";
                oSheet.get_Range("A1", "D1").Interior.Color = Excel.XlRgbColor.rgbBlack;
                oSheet.get_Range("B1").ColumnWidth = "70";
                WriteData();

                oXL.Visible = false;
                oXL.UserControl = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    oWB.SaveAs(saveFileDialog1.FileName,
                    Excel.XlSaveAsAccessMode.xlNoChange);
                }
                oWB.Close(0);
                oXL.Quit();
                Form1.form.RemoveWait();
                MessageBox.Show("Excel File saved successfully!\n"+saveFileDialog1.InitialDirectory, "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1.form.Opacity = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Saving Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                Form1.form.RemoveWait();
                Form1.form.Opacity = 1;
                UseWaitCursor = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                foreach (string txt in Program.list)
                {
                    listBox1.Items.Add(txt);
                }
            }
            catch (Exception) { }
        }
        public string[] getSelectedItemsArray()
        {
            string[] strArray = new string[listBox1.Items.Count];
            listBox1.Items.CopyTo(strArray, 0);
            return strArray;
        }
        public void WriteData()
        {
            int x = 2;
            string[] strArray = getSelectedItemsArray();
            foreach (string str in strArray)
            {
                oSheet.get_Range(("A" + x), ("D" + x)).Interior.Color = Excel.XlRgbColor.rgbBlue;
                string Fake1 = generateFakeCode();
                oSheet.Cells[x, 1] = Fake1;
                oSheet.Cells[x, 3] = generateFakeCHr();
                string Fake2 = generateFakeCode();
                while (Fake1 == Fake2)
                    Fake2 = generateFakeCode();
                oSheet.Cells[x, 4] = Fake2;
                oSheet.Cells[x++, 2] = str;

            }
        }
        public string generateFakeCode()
        {
            string fake = "";
            string[] fakeArray = new string[] { "ELE", "ELE", "ELC", "BAS", "CLS", "CLW", "ARC", "CIW", "ARC", "MEP", "ARC", "MED", "HUM", "IEN", "CHE" };
            int randNum = new Random().Next(100, 452);
            int randIndex = new Random().Next(0, fakeArray.Length - 1);
            fake = fakeArray[randIndex] + randNum;
            return fake;
        }
        public string generateFakeCHr()
        {
            string fake = "";
            string[] fakeArray = new string[] { "1", "2", "2", "2", "3", "3", "3", "3", "3", "3", "3", "3", "3", "3", "3", "3", "4", "4", "4", "4", "4" };
            int randIndex = new Random().Next(0, fakeArray.Length - 1);
            fake = fakeArray[randIndex];
            return fake;
        }
    }
}