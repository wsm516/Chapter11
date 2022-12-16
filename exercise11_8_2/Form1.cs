using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace exercise11_8_2 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            if (treeView1.SelectedNode.Nodes != null)
            {
                foreach (TreeNode node in treeView1.SelectedNode.Nodes)
                {
                    listView1.Items.Add(node.Text, node.ImageIndex);
                }
            }
        }
    }
} 
