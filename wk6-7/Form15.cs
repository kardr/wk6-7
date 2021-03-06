﻿using System;
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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.ContextMenuStrip = contextMenuStrip1;
                c.MouseDown += new MouseEventHandler(this.ShowPopupMenu);
            }
        }
        private void ShowPopupMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Control c = (Control)sender;
                if (c.ContextMenuStrip != null)
                {
                    c.ContextMenuStrip.Show(c, new Point(e.X, e.Y));
                }
            }
        }
    }
}
