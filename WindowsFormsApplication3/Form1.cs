using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Design design = null;
        public static Form1 form;
        public Form1()
        {
            InitializeComponent();
            design = new Design(btn1, btn2, btn3, btn4, panelL, panelT);
            form = this;
        }
        
        //  
        /** Click Buttons Events and Effects**/
        //
        private void btn1_Click(object sender, EventArgs e)
        {
            design.SetActiveButtonColorEffect(btn1);
            design.ShowUserControl(information2);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            design.SetActiveButtonColorEffect(btn2);
            design.ShowUserControl(regstration1);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            design.SetActiveButtonColorEffect(btn3);
            design.ShowUserControl(gpa11);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            design.SetActiveButtonColorEffect(btn4);
           // design.ShowUserControl(options1);
        }

        //
        /** Mouse Enter and Leave Buttons Events and Effects**/
        //
        
        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            design.SetMouseEnterEffect(btn1);
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            design.SetMouseLeaveEffect(btn1);
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            design.SetMouseEnterEffect(btn2);
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            design.SetMouseLeaveEffect(btn2);
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            design.SetMouseEnterEffect(btn3);
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            design.SetMouseLeaveEffect(btn3);
        }

        private void btn4_MouseEnter(object sender, EventArgs e)
        {
            design.SetMouseEnterEffect(btn4);
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            design.SetMouseLeaveEffect(btn4);
        }

        private void regstration2_Load(object sender, EventArgs e)
        {

        }

        public void BringWait()
        {
            wait1.Start();
            wait1.BringToFront();
        }
        public void RemoveWait()
        {
            wait1.Stop();
            regstration1.BringToFront();
        }
    }
}
