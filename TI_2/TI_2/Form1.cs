using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Register_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == '0') return;
            if ((char)e.KeyChar == '1') return;
            e.Handled = true;
        }
    }
}
