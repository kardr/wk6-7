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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public int num = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            num++;
            ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
            mi.Click += this.toolStripMenuItem1_Click;
            toolStripMenuItem1.DropDownItems.Add(mi);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string s = ((ToolStripMenuItem)sender).Text;
            MessageBox.Show(s);

        }
    }
}
