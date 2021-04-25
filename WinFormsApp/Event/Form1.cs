using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddText(", ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddText(".");
        }

        public void AddText(string endSymbol)
        {
            label1.Text = label1.Text + endSymbol;
            textBox1.Clear();
        }

        public void Clear()
        {
            label1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
                label1.Text = label1.Text + e.KeyChar;
            else
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
        }
    }
}
