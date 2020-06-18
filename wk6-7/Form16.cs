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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                treeView1.Nodes.Add(addNodeTextBox.Text);
            }
            else
            {
                node.Nodes.Add(addNodeTextBox.Text);
            }
            addNodeTextBox.Text = "";
            addNodeTextBox.Focus();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node != null)
            {
                treeView1.Nodes.Remove(node);
            }
            else
            {
                MessageBox.Show("Ничего не выделено");
            }
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
            TreeNode tn = FindNode(treeView1.Nodes, findNodeTextBox.Text);
            if (tn != null)
            {
                treeView1.SelectedNode = tn;
                treeView1.Focus();
            }
        }
       
        private TreeNode FindNode(TreeNodeCollection tnc, string name)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.Text == name)
                {
                    return tn;
                }
            }
            TreeNode node;
            foreach (TreeNode tn in tnc)
            {
                node = FindNode(tn.Nodes, name);
                if (node != null)
                {
                    return node;
                }
            }
            return null;
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            TreeNode treeNode = treeView1.Nodes.Add("Item1");
            TreeNode treeNode11 = treeNode.Nodes.Add("Item11");
            TreeNode treeNode12 = treeNode.Nodes.Add("Item12");
            treeNode11.Nodes.Add("Item111");
            treeNode11.Nodes.Add("Item112");
            treeNode12.Nodes.Add("Item121");
            treeNode12.Nodes.Add("Item122");
            treeNode.ExpandAll();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            SelectAllSubnodes(e.Node);
        }

        void SelectAllSubnodes(TreeNode treeNode)
        {
            foreach (TreeNode treeSubNode in treeNode.Nodes)
            {
                treeSubNode.Checked = treeNode.Checked;
            }
        }
    }
}
