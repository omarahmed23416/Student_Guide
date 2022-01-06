using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication3
{
    class GPADesign 
    {
        GPA_calculator gpa = new GPA_calculator();
        public static bool display = true;
        
        List<TextBox> textBoxList;
        List<ComboBox> comboBoxList;
        Label CumGPALabel, SemeGPALabel;

        public GPADesign(gpa1 obj, Label CumGPALabel, Label SemeGPALabel)
        {
            this.textBoxList = obj.textBoxList;
            this.comboBoxList = obj.comboBoxList;
            this.CumGPALabel = CumGPALabel;
            this.SemeGPALabel = SemeGPALabel;
        }    

        public void EnableDisableMarkTextBox(ComboBox g, TextBox m)
        {
            if (g.Text == "")
                m.Enabled = true;
            else
            {
                ResetColors(g);
                m.Enabled = false;
                m.Text = "";
            }
        }

        public void SetGrade(ComboBox g, TextBox m)
        {
            if (m.Text != "" && CheckMarkLimits(m, g))
                g.Text = gpa.GradeFromMark(m.Text);
        }

        public void ResetColors(TextBox t)
        {
            t.BackColor = Color.White;
            if(t.Text == gpa.tCHString || t.Text == gpa.tGPAString)
               t.ForeColor = Color.LightGray;
            else
                t.ForeColor = Color.DodgerBlue;
        }

        public void ResetColors(ComboBox c)
        {
            c.BackColor = Color.White;
            c.ForeColor = Color.DodgerBlue;
        }

        public void ResetAllColors() {
            foreach(TextBox textBox in textBoxList) {
                ResetColors(textBox);
            }
        }

        public void SetGPALableColors(GPA_calculator gpa)
        {
            CumGPALabel.ForeColor = (gpa.GetCumulativeGPA() < 2) ? Color.Red : (gpa.GetCumulativeGPA() < 3.5) ? Color.DodgerBlue : Color.LimeGreen;
            SemeGPALabel.ForeColor = (gpa.GetSemesterGPA() < 2) ? Color.Red : (gpa.GetSemesterGPA() < 3.5) ? Color.DodgerBlue : Color.LimeGreen;
        }

        public void CheckValues()
        {
            CumGPALabel.Text = "";
            SemeGPALabel.Text = "";
            ResetAllColors();
            ResetAllColors();
            for (int i = 0; i < 9; i++)
            {
                Check(comboBoxList[i], textBoxList[i+11]);
            }
            Check(textBoxList[9], textBoxList[10]);
        }

        public void Check(ComboBox g, TextBox c)
        {
            if (g.Text != "" && c.Text == "")
            {
                c.BackColor = Color.Red;
                c.ForeColor = Color.White;
                display = false;
            }
            if (g.Text == "" && c.Text != "")
            {
                g.BackColor = Color.Red;
                g.ForeColor = Color.White;
                display = false;
            }
        }

        public void Check(TextBox tGPA, TextBox tCH)
        {
            if (tGPA.Text != gpa.tGPAString && tCH.Text == gpa.tCHString)
            {
                tCH.BackColor = Color.Red;
                tCH.ForeColor = Color.White;
                display = false;
            }
            if (tGPA.Text == gpa.tGPAString && tCH.Text != gpa.tCHString)
            {
                tGPA.BackColor = Color.Red;
                tGPA.ForeColor = Color.White;
                display = false;
            }
        }

        public bool CheckMarkLimits(TextBox m, ComboBox g)
        {
            int val = int.Parse((m.Text == "") ? "0" : m.Text);
            if (val > 100 || val < 0)
            {
                m.ForeColor = Color.White;
                m.BackColor = Color.Red;
                g.Enabled = false;
                display = false;
                return false;
            }
            else
            {
                m.ForeColor = Color.DodgerBlue;
                m.BackColor = Color.White;
                display = false;
                g.Enabled = true;
            }
            return true;
        }

        public bool CheckCHLimits(TextBox ch)
        {
            float val = float.Parse((ch.Text == "" || ch.Text == gpa.tCHString) ? "0" : ch.Text);
            if (val > 200)
            {
                ch.ForeColor = Color.White;
                ch.BackColor = Color.Red;
                display = false;
                return false;
            }
            else
            {
                ResetColors(ch);
            }
            return true;
        }

        public bool CheckGPALimits(TextBox tG)
        {
            float val = float.Parse((tG.Text == "" || tG.Text == gpa.tGPAString) ? "0" : tG.Text);
            if (val > 4)
            {
                tG.ForeColor = Color.White;
                tG.BackColor = Color.Red;
                display = false;
                return false;
            }
            else
            {
                ResetColors(tG);
            }
            return true;
        }

        public void AddValuesTogpaObject(GPA_calculator gpa)
        {
            for (int i = 0; i < 9; i++)
            {
                gpa.AddToScale(comboBoxList[i].Text, textBoxList[i + 11].Text);
            }
            gpa.AddLastgpa(textBoxList[9].Text, textBoxList[10].Text);
        }

        public void DisplayValues(GPA_calculator gpa)
        { 
            if (display)
            {
                CumGPALabel.Text = string.Format("{0:f}", gpa.GetCumulativeGPA());
                SemeGPALabel.Text = string.Format("{0:f}", gpa.GetSemesterGPA());
            }
        }

    }
}
