using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication3
{
    public partial class gpa1 : UserControl
    {
        string tGPAString = "Enter you total GPA";
        string tCHString = "Enter your total credit hours";
        string nString = "e.g. course ";
        GPADesign gpaDesign;

        public List<TextBox> textBoxList = new List<TextBox>();
        public List<ComboBox> comboBoxList = new List<ComboBox>();

        Design design = new Design();
        GPA_calculator gpa = new GPA_calculator();

        public gpa1()
        {
            InitializeComponent();
            PrepareElements();
        }

        public void PrepareElements()
        {
            for (int i = 1; i <= 9; i++)
            {
                textBoxList.Add((TextBox)Controls.Find("m" + i, true)[0]);
                comboBoxList.Add((ComboBox)Controls.Find("g" + i, true)[0]);
            }

            textBoxList.Add((TextBox)Controls.Find("tGPA", true)[0]);
            textBoxList.Add((TextBox)Controls.Find("tCH", true)[0]);

            for (int i = 1; i <= 9; i++)
            {
                textBoxList.Add((TextBox)Controls.Find("c" + i, true)[0]);
            }
            gpaDesign = new GPADesign(this, CumGPALabel, SemeGPALabel);
        }

        private void tGPAText_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(tGPA, tGPAString);
        }
        private void tGPAText_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(tGPA, tGPAString);
        }

        private void tCHText_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(tCH, tCHString);
        }
        private void tCHText_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(tCH, tCHString);
        }


        private void n1_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(n1, nString + 1);
        }
        private void n1_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(n1, nString + 1);
        }

        private void n2_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(n2, nString + 2);
        }
        private void n2_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(n2, nString + 2);
        }

        private void n3_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(n3, nString + 3);
        }
        private void n3_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(n3, nString + 3);
        }

        private void n4_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(n4, nString + 4);
        }
        private void n4_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(n4, nString + 4);
        }

        private void n5_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(n5, nString + 5);
        }
        private void n5_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(n5, nString + 5);
        }

        private void n6_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(n6, nString + 6);
        }
        private void n6_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(n6, nString + 6);
        }

        private void n7_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(n7, nString + 7);
        }
        private void n7_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(n7, nString + 7);
        }

        private void n8_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(n8, nString + 8);
        }
        private void n8_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(n8, nString + 8);
        }

        private void n9_Enter(object sender, EventArgs e)
        {
            design.PlaceHolderEnter(n9, nString + 9);
        }
        private void n9_Leave(object sender, EventArgs e)
        {
            design.PlaceHolderLeave(n9, nString + 9);
        }

        // Enable and Disable mark textBox  
        private void g1_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.EnableDisableMarkTextBox(g1, m1);
        }
        private void g2_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.EnableDisableMarkTextBox(g2, m2);
        }
        private void g3_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.EnableDisableMarkTextBox(g3, m3);
        }
        private void g4_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.EnableDisableMarkTextBox(g4, m4);
        }
        private void g5_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.EnableDisableMarkTextBox(g5, m5);
        }
        private void g6_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.EnableDisableMarkTextBox(g6, m6);
        }
        private void g7_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.EnableDisableMarkTextBox(g7, m7);
        }
        private void g8_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.EnableDisableMarkTextBox(g8, m8);
        }
        private void g9_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.EnableDisableMarkTextBox(g9, m9);
        }

        // Set Grade automatically when mark textBox is focus leaved
        private void m1_Leave(object sender, EventArgs e)
        {
            gpaDesign.SetGrade(g1, m1);
        }
        private void m2_Leave(object sender, EventArgs e)
        {
            gpaDesign.SetGrade(g2, m2);
        }
        private void m3_Leave(object sender, EventArgs e)
        {
            gpaDesign.SetGrade(g3, m3);
        }
        private void m4_Leave(object sender, EventArgs e)
        {
            gpaDesign.SetGrade(g4, m4);
        }
        private void m5_Leave(object sender, EventArgs e)
        {
            gpaDesign.SetGrade(g5, m5);
        }
        private void m6_Leave(object sender, EventArgs e)
        {
            gpaDesign.SetGrade(g6, m6);
        }
        private void m7_Leave(object sender, EventArgs e)
        {
            gpaDesign.SetGrade(g7, m7);
        }
        private void m8_Leave(object sender, EventArgs e)
        {
            gpaDesign.SetGrade(g8, m8);
        }
        private void m9_Leave(object sender, EventArgs e)
        {
            gpaDesign.SetGrade(g9, m9);
        }

        // Handel the input to the text boxes
        private void AcceptFloatValuesOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');
        }
        private void AcceptIntValuesOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        // Handel the input limits not to excees the max or min values
        private void tGPA_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckGPALimits(tGPA);
        }

        private void m1_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckMarkLimits(m1, g1);
        }
        private void m2_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckMarkLimits(m2, g2);
        }
        private void m3_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckMarkLimits(m3, g3);
        }
        private void m4_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckMarkLimits(m4, g4);
        }
        private void m5_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckMarkLimits(m5, g5);
        }
        private void m6_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckMarkLimits(m6, g6);
        }
        private void m7_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckMarkLimits(m7, g7);
        }
        private void m8_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckMarkLimits(m8, g8);
        }
        private void m9_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckMarkLimits(m9, g9);
        }

        private void tCHText_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(tCH);
        }
        private void c1_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(c1);
        }
        private void c2_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(c2);
        }
        private void c3_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(c3);
        }
        private void c4_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(c4);
        }
        private void c5_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(c5);
        }
        private void c6_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(c6);
        }
        private void c7_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(c7);
        }
        private void c8_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(c8);
        }
        private void c9_TextChanged(object sender, EventArgs e)
        {
            gpaDesign.CheckCHLimits(c9);
        }

        // Clac Button Click Event 
        private void button1_Click(object sender, EventArgs e)
        {
            gpaDesign.CheckValues();
            gpaDesign.AddValuesTogpaObject(gpa);
            gpaDesign.SetGPALableColors(gpa);
            gpaDesign.DisplayValues(gpa);
            GPADesign.display = true;
            gpa = new GPA_calculator();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                ((TextBox)Controls.Find("n" + i, true)[0]).Text = "e.g. course " + i;
                ((TextBox)Controls.Find("n" + i, true)[0]).ForeColor = Color.LightGray;
            }
            for (int i = 0; i < 9; i++)
            {
                textBoxList[i].Text = "";
            } 
            for (int i = 11; i < 20; i++)
            {
                textBoxList[i].Text = "";
            } 
            foreach (ComboBox cmb in comboBoxList)
            {
                cmb.Text = "";
            }
            tGPA.Text = tGPAString;
            tCH.Text = tCHString;
            SemeGPALabel.Text = "";
            CumGPALabel.Text = "";
            gpaDesign.ResetAllColors();

        }

    }
}


         

    

