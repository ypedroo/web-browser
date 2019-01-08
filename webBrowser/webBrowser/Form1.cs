using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("A button was clicker \r\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Entrou mermao \r\n");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Saiu mermao \r\n");
        }
    }
}
