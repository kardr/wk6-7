using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk6_7
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is ButtonBase)
                {
                    ((ButtonBase)c).FlatStyle = FlatStyle.Popup;
                }
            }
        }
    }
}
