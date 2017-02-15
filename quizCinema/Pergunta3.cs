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
    public partial class Pergunta3 : Form
    {
        string nomeCompleto = "";
        int id;
        public Pergunta3(string nomeJogador, int idJogador)
        {
            InitializeComponent();
            nomeCompleto = nomeJogador;
            id = idJogador;
        }

        private void Pergunta3_Load(object sender, EventArgs e)
        {
            lblNomeSobrenome.Text = nomeCompleto;
            lblPergunta3.Text = "3. Qual o fim do filme Titanic? (4 pontos)";
            rb1.Text = "a) Os passageiros usam jet-ski.";
            rb2.Text = "b) Os passageiros continuam a viagem no navio da guarda-costeira.";
            rb3.Text = "c) Os piratas do Caribe saqueiam o navio.";
            rb4.Text = "d) O navio afunda.";
        }

        private void btn03_04_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=SAMSUNG-SERIE-9\\SQLEXPRESS;Database=quizCinema; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_Perguntas (pergunta, resposta_correta, nivel, pontos, id_jogador) values (@PERG, @RESP_CORR, @NIVEL, @PONTOS, @ID_JOgador)", conexao))
                {
                    if (rb4.Checked)
                    {
                        cmd.Parameters.AddWithValue("PERG", lblPergunta3.Text);
                        cmd.Parameters.AddWithValue("RESP_CORR", rb3.Text);
                        cmd.Parameters.AddWithValue("NIVEL", "Moderado");
                        cmd.Parameters.AddWithValue("Pontos", 4);
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
