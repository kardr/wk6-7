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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.AddRange(new ToolStripItem[]
             {
                 this.cutToolStripMenuItem,
                 this.copyToolStripMenuItem,
                 this.pasteToolStripMenuItem
             });
             this.ContextMenuStrip = cms;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Файл");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Редактирование");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Вырезать");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Копировать");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вставить");
        }
    }
}
