using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol2_retezce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                listBox1.Items.Clear();
                string input = textBox1.Text;
                string[] words = input.Split(' ', '\t');
                foreach (string lol in words) {
                    foreach (char xd in lol) {
                        if (xd >= '0' && xd <= '9') { listBox1.Items.Add(lol.ToString()); break; }
                    }

                }
            }
            catch { MessageBox.Show("Špatná hodnota!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
