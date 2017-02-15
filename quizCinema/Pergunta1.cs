using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizCinema
{
    public partial class Pergunta1 : Form
    {
        string nomeCompleto = "";
        int id;
        public Pergunta1(string nomeJogador, int idJogador)
        {
            InitializeComponent();
            nomeCompleto = nomeJogador;
            id = idJogador;
        }

        private void Pergunta1_Load(object sender, EventArgs e)
        {
            lblNomeSobrenome.Text = nomeCompleto;
            lblPergunta1.Text = "1. Sylvester Stallone interpretou todos os personagens abaixo, exceto: (1 ponto)";
            rb1.Text = "a) Cobra";
            rb2.Text = "b) Rambo";
            rb3.Text = "c) Soldado universal";
            rb4.Text = "d) Rocky";
        }

        private void btn01_02_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=SAMSUNG-SERIE-9\\SQLEXPRESS;Database=quizCinema; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_Perguntas (pergunta, resposta_correta, nivel, pontos, id_jogador) values (@PERG, @RESP_CORR, @NIVEL, @PONTOS, @ID_JOgador)", conexao))
                {
                    if (rb3.Checked)
                    {
                        cmd.Parameters.AddWithValue("PERG", lblPergunta1.Text);
                        cmd.Parameters.AddWithValue("RESP_CORR", rb3.Text);
                        cmd.Parameters.AddWithValue("NIVEL", "Fácil");
                        cmd.Parameters.AddWithValue("Pontos", 1);
                        cmd.Parameters.AddWithValue("ID_JOgador", id);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                    Close();
                }
            }
        }
    }
}
