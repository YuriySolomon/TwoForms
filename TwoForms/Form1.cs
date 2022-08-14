using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoForms
{    
    public partial class Form1 : Form
    {
        private Form2 F2 = null;
        public Form1()
        {
            InitializeComponent(); 
            F2 = new Form2(this);
            F2.Show();
        }              

        public string Info
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           F2.Info = textBox1.Text;
        }
    }
}
