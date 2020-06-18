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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        Font userFont = DefaultFont;
        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                userFont = fontDialog1.Font;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Test", userFont, Brushes.Blue, 80, 20);
            base.OnPaint(e);
        }
    }
}
