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
    public partial class civil : UserControl
    {
        public civil()
        {
            InitializeComponent();
        }
        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Program.list = checkedListBox1.CheckedItems;
        }
        public void Clear()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemCheckState(i, (CheckState.Unchecked));
        }
    }
}
