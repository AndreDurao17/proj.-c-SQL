using System;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using MySql;
using System.Threading.Tasks;

namespace M16_EXAME202112_PSI18H_AndreDurao_2218041
{
    public partial class Form4 : Form
    {
        public static string SetValueForText1 = ""; //string para o numero de edições
        public static string DataText = ""; //string para a data da assinatura

        ////Ligação á base de dados
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sub;";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistar1_Click(object sender, EventArgs e)
        {
            int dia;
            dia = int.Parse(textBox1.Text);

            int ano;
            ano = int.Parse(textBox4.Text);

            int mes;
            mes = int.Parse(textBox3.Text) + 2; //no mes tem de estar +2 para quando passar o mes 11 ou 12 passar diretamente para os proximos meses do ano
            if (int.Parse(textBox3.Text) == 12)
            {
                ano = int.Parse(textBox4.Text) + 1;
                mes = 2;
            }
            else if (int.Parse(textBox3.Text) == 11)
            {
                ano = int.Parse(textBox4.Text) + 1;
                mes = 1;
            }

            string data;
            data = dia + "/" + mes + "/" + ano;

            DataText = data; //Tudo o que está desta linha para cima foi feito para criar uma ligação entre este forms com o forms 3 na data de renovação da subscrição
            SetValueForText1 = textBox2.Text; //Ajudou na passagem de string deste forms para o forms 3

            //Ligação á base de dados
            MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=sub;");
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO sub(data, edicao) VALUES (@data, @edicao)", conn);
            cmd.Parameters.AddWithValue("@data", textBox1.Text);
            cmd.Parameters.AddWithValue("@edicao", data);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();

            //usei isto para mudar os forms e escondelos após usados
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imagemLocalizacao = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagemLocalizacao = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um Erro Ocurreu!!!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
