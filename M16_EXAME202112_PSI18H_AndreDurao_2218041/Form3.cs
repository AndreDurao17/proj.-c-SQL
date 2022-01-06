using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M16_EXAME202112_PSI18H_AndreDurao_2218041
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Está assim feito para a passagem de strings e ints entre forms
            label3.Text = Form2.SetValueForText1;
            label3.Text = Form4.SetValueForText1;
            label4.Text = Form2.DataText;
            label4.Text = Form4.DataText;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //usei isto para mudar os forms e escondelos após usados
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
