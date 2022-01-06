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
    public partial class Information : UserControl
    {
        public Information()
        {
            InitializeComponent();
            webBrowser2.Navigate(new Uri("file:///C:/Users/omara/OneDrive/Documents/Visual%20Studio%202013/Projects/Student%20Guide/WindowsFormsApplication3/Student-Guide.pdf"));
        }

    }
        
}
