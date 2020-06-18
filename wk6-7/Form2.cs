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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                label1.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                //label1.Text = ex.Message;
                statusStrip1.Items[0].Text = ex.Message;
            }
            catch
            {
                label1.Text = "Неизвестная ошибка";
            }
        }

        private void statusStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Сlicked status bar");
        }

        private void toolStripStatusLabel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Blue, width: 2), 16, 2, 15, 15);
        }
    }
}
