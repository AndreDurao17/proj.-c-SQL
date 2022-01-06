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
            //usei isto para mudar os forms e escondelos após usados
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            //usei isto para mudar os forms e escondelos após usados
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
