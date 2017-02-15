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
    public partial class Pergunta4 : Form
    {
        string nomeCompleto = "";
        int id;
        public Pergunta4(string nomeJogador, int idJogador)
        {
            InitializeComponent();
            nomeCompleto = nomeJogador;
            id = idJogador;
        }

        private void Pergunta4_Load(object sender, EventArgs e)
        {
            lblNomeSobrenome.Text = nomeCompleto;
            lblPergunta4.Text = "O enredo de \"Corrida Mortal\" retrata: (8 pontos)";
            rb1.Text = "a) uma competição de carros em um presídio.";
            rb2.Text = "b) uma disputa de sobrevivência no deserto.";
            rb3.Text = "c) uma busca por comida em uma floresta.";
            rb4.Text = "d) a rotina do brasileiro que ganha um salário mínimo.";
        }

        private void btn04_Final_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS;Database=quizCinema; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_Perguntas (pergunta, resposta_correta, nivel, pontos, id_jogador) values (@PERG, @RESP_CORR, @NIVEL, @PONTOS, @ID_JOgador)", conexao))
                {
                    if (rb1.Checked)
                    {
                        cmd.Parameters.AddWithValue("PERG", lblPergunta4.Text);
                        cmd.Parameters.AddWithValue("RESP_CORR", rb3.Text);
                        cmd.Parameters.AddWithValue("NIVEL", "Difícil");
                        cmd.Parameters.AddWithValue("Pontos", 8);
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
