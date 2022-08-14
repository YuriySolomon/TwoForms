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
    public partial class Form2 : Form
    {
        private Form1 F1 = null;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            F1 = parent;
        }

        public string Info
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            F1.Info = textBox1.Text;
            
        }
            
    }
}
