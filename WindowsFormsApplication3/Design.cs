using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication3
{
    class Design
    {
        public Color SelectedButtonColor = Color.RoyalBlue;
        public Color EnteredButtonColor = Color.FromArgb(70, 100, 100, 100);
        public Color ButtonBorderColor = Color.FromArgb(81, 79, 80);
        public Color TextColor = Color.DodgerBlue;

        GPA_calculator gpa = new GPA_calculator();

        Button btn1, btn2, btn3, btn4;
        Panel panelL, panelT;

        //
        // This constructor to get refrence from form private elements
        //
        public Design(Button btn1, Button btn2, Button btn3, Button btn4, Panel panelL, Panel panelT)
        {
            this.btn1 = btn1;
            this.btn2 = btn2;
            this.btn3 = btn3;
            this.btn4 = btn4;
            this.panelL = panelL;
            this.panelT = panelT;
            RemoveDefaultButtonsHoverEffect();
            btn1.BackColor = SelectedButtonColor;
            btn1.FlatAppearance.BorderColor = SelectedButtonColor;
        }

        public Design()
        {
             
        }

        public void ShowUserControl(UserControl UC)
        {
            try
            {
                UC.BringToFront();
            }
            catch(Exception){}
        }

        public void SetActiveButtonColorEffect(Button btn)
        {
            ResetAllButtonColor();
            btn.BackColor = SelectedButtonColor;
            btn.FlatAppearance.BorderColor = SelectedButtonColor;
        }

        public void SetMouseEnterEffect(Button btn)
        {
            if (btn.BackColor != SelectedButtonColor)
            {
                btn.BackColor = EnteredButtonColor;
            }
        }

        public void SetMouseLeaveEffect(Button btn)
        {
            if (btn.BackColor != SelectedButtonColor)
            {
                btn.BackColor = btn.Parent.BackColor;
            }
        }

        public void ResetAllButtonColor()
        {
            Color defultColor = btn1.Parent.BackColor;
            btn1.BackColor = defultColor;
            btn2.BackColor = defultColor;
            btn3.BackColor = defultColor;
            btn4.BackColor = defultColor;

            btn1.FlatAppearance.BorderColor = ButtonBorderColor;
            btn2.FlatAppearance.BorderColor = ButtonBorderColor;
            btn3.FlatAppearance.BorderColor = ButtonBorderColor;
            btn4.FlatAppearance.BorderColor = ButtonBorderColor;
        }

        // Stack OverFlow :) COPY AND PASTE
        public void RemoveDefaultButtonsHoverEffect()
        {
            btn1.FlatAppearance.MouseOverBackColor = btn1.BackColor;
            btn2.FlatAppearance.MouseOverBackColor = btn2.BackColor;
            btn3.FlatAppearance.MouseOverBackColor = btn3.BackColor;
            btn4.FlatAppearance.MouseOverBackColor = btn4.BackColor;

            btn1.BackColorChanged += (s, e) =>
            {
                btn1.FlatAppearance.MouseOverBackColor = btn1.BackColor;
            };
            btn2.BackColorChanged += (s, e) =>
            {
                btn2.FlatAppearance.MouseOverBackColor = btn2.BackColor;
            };
            btn3.BackColorChanged += (s, e) =>
            {
                btn3.FlatAppearance.MouseOverBackColor = btn3.BackColor;
            };
            btn4.BackColorChanged += (s, e) =>
            {
                btn4.FlatAppearance.MouseOverBackColor = btn4.BackColor;
            };
        }   

        public void PlaceHolderEnter(TextBox txt, string placeHolderTxt)
        {
            if (txt.Text == placeHolderTxt)
            {
                txt.Text = "";
                txt.ForeColor = TextColor;
            }
        }
        public void PlaceHolderLeave(TextBox txt, string placeHolderTxt)
        {
            if (txt.Text == "")
            {
                txt.Text = placeHolderTxt;
                txt.ForeColor = Color.LightGray;
            }
        }

        public void EnableNewFields(ComboBox gUp, TextBox n, ComboBox g, NumericUpDown m, NumericUpDown c)
        {
            if (gUp.Text != "")
            {
                n.Enabled = true;
                g.Enabled = true;
                m.Enabled = true;
                c.Enabled = true;
            }
            else
            {
                n.Enabled = false;
                g.Enabled = false;
                m.Enabled = false;
                c.Enabled = false;
            }
        }


    }
}

