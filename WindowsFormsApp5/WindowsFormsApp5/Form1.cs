using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int leng = Convert.ToInt32(textBox1.Text);
            int wid = Convert.ToInt32(textBox2.Text);
            int heig = Convert.ToInt32(textBox3.Text);
            square mysqur = new square();
            rectangle cas = new rectangle();
            mysqur.setLenght(leng);
            mysqur.setWidht(wid);
            mysqur.setHeigth(heig);
            MessageBox.Show("Area is " + mysqur.calculatesquarearea());
        }
    }
}
