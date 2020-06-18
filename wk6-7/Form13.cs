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
    internal interface ISomeInterface
    {
        void SomeMethod();
    }

    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Type t = Type.GetType("wk6_7" + textBox1.Text);
            ISomeInterface w = (wk6_7.ISomeInterface)Activator.CreateInstance(t);
            w.SomeMethod();
        }
    }
    public class Class1 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class1");
        }
    }

    public class Class2 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class2");
        }
    }
}
