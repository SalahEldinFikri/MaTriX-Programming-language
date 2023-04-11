using com.calitha.goldparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compiler
{
    public partial class Compiler : Form
    {
        MyParser pars;
        public Compiler()
        {
            InitializeComponent();
            pars = new MyParser("project.cgt", listBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pars.Parse(textBox1.Text);
        }
    }
}
