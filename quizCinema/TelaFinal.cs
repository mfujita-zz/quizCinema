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
    public partial class TelaFinal : Form
    {
        string nomeCompleto = "";
        int id;

        public TelaFinal(string nomeJogador, int idJogador)
        {
            InitializeComponent();
            nomeCompleto = nomeJogador;
            id = idJogador;
        }

        private void TelaFinal_Load(object sender, EventArgs e)
        {
            lblNome.Text = nomeCompleto + ", sua pontuação foi";

            using (SqlConnection conexao = new SqlConnection("Server=SAMSUNG-SERIE-9\\SQLEXPRESS; Database=quizCinema; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("select sum(pontos) from tb_perguntas where id_jogador = @IDJOGADOR", conexao))
                {
                    cmd.Parameters.AddWithValue("IDJOGADOR", id);
                    conexao.Open();

                    int pontos = (int)cmd.ExecuteScalar();

                    lblPontos.Text = pontos + " PONTOS";
                }
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
