using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_ivaniaguzman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            label1.Text = "Ivania Guzman";
            label2.Text = "Monica Campos";
            label3.Text = "Lorena Rodiguez";
            label4.Text = "Fredy Campos";
            label5.Text = "Cristian Herrera";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
