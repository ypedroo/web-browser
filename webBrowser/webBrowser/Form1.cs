﻿using System;
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

        //This function is used to configure the exit method
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by Ynoa Pedro Based on the Barnacules Codegarsm #5");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        //This is a core function that will perform all navigation and post processing
        private void NavigateToPage()
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        //Onclick will show the textbox
        private void Navigate_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }
               

        //this func is activated when the button is clicked
        private void Navigate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)ConsoleKey.Enter )
            {
                //NavigateToPage();
                Navigate_Click(null, null);
            }
        }
    }
}

