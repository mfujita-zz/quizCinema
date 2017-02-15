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
            if (Form1.acertos == 4)
            { 
                lblMensagem.Text = "Parabéns!";
            }
            else if (Form1.acertos == 2 || Form1.acertos == 3)
            { 
                lblMensagem.Text = "Foi bem!";
            }
            else
                lblMensagem.Text = "Precisa estudar.";

            lblNome.Text = nomeCompleto + ", sua pontuação foi";

            using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS; Database=quizCinema; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("select count(@@ROWCOUNT) from tb_perguntas where id_jogador = @IDJOGADOR", conexao))
                {
                    cmd.Parameters.AddWithValue("IDJOGADOR", id);
                    conexao.Open();
                    int acertos = (int)cmd.ExecuteScalar();

                    if (acertos == 4)
                        lblMensagem.Text = "Parabéns!";
                    else if (Form1.acertos == 2 || Form1.acertos == 3)
                        lblMensagem.Text = "Foi bem!";
                    else
                        lblMensagem.Text = "Precisa estudar.";

                    if (Form1.acertos != acertos)
                        MessageBox.Show("O programa está mostrando divergência de contagem.");
                }


                using (SqlCommand cmd = new SqlCommand("select sum(pontos) from tb_perguntas where id_jogador = @IDJOGADOR", conexao))
                {
                    cmd.Parameters.AddWithValue("IDJOGADOR", id);

                    int pontos = 0;

                    try
                    { 
                        pontos = (int)cmd.ExecuteScalar();
                    }
                    catch
                    {
                        pontos = 0;
                    }
                    
                    lblNome.Text = nomeCompleto + ", sua pontuação foi";
                    lblPontos.Text = pontos + " PONTOS";
                }
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJogarDeNovo_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
