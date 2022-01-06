using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Wait : UserControl
    {

        public Wait()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void Start()
        {
            timer1.Start();
        }
        public void Stop()
        {
            timer1.Stop();
        }

        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x > 5)
            {
                label1.Text = "Please wait while saving your file";
                x = 0;
            }
            label1.Text += ".";
            x++;
        }
    }
}
