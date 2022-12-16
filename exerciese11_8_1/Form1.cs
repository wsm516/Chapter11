using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace exerciese11_8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.FocusedItem.Text=="메모장")
            {
                System.Diagnostics.Process.Start("notepad");
            }
            else if (listView1.FocusedItem.Text=="계산기")
            {
                System.Diagnostics.Process.Start("calc");
            }
            else if (listView1.FocusedItem.Text=="그림판")
            {
                System.Diagnostics.Process.Start("mspaint");
            }
        }
    }
}
