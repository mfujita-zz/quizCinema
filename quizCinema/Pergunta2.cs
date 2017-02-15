using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizCinema
{
    public partial class Pergunta2 : Form
    {
        string nomeCompleto = "";
        int id;
        public Pergunta2(string nomeJogador, int idJogador)
        {
            InitializeComponent();
            nomeCompleto = nomeJogador;
            id = idJogador;
        }

        private void Pergunta2_Load(object sender, EventArgs e)
        {
            lblNomeSobrenome.Text = nomeCompleto;
            lblPergunta2.Text = "Sandra Bullock estreou em qual dos filmes abaixo? (2 pontos)";
            rb1.Text = "a) Velocidade máxima";
            rb2.Text = "b) Uma linda mulher";
            rb3.Text = "c) 11 homens e 1 segredo";
            rb4.Text = "d) Resident evil";
            BackColor = System.Drawing.ColorTranslator.FromHtml("#3D332A");
        }

        private void btn02_03_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS;Database=quizCinema; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_Perguntas (pergunta, resposta_correta, nivel, pontos, id_jogador) values (@PERG, @RESP_CORR, @NIVEL, @PONTOS, @ID_JOgador)", conexao))
                {
                    if (rb1.Checked)
                    {
                        cmd.Parameters.AddWithValue("PERG", lblPergunta2.Text);
                        cmd.Parameters.AddWithValue("RESP_CORR", rb3.Text);
                        cmd.Parameters.AddWithValue("NIVEL", "Fácil");
                        cmd.Parameters.AddWithValue("Pontos", 2);
                        cmd.Parameters.AddWithValue("ID_JOgador", id);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        Form1.acertos++;
                    }
                    Close();
                }
            }
        }
    }
}
