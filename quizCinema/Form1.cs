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
    public partial class Form1 : Form
    {
        public static int acertos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS;Database=quizCinema; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_jogador(nome, sobrenome, email) OUTPUT INSERTED.ID_jogador values (@NOME, @SOBRENOME, @EMAIL)", conexao))
                {
                    cmd.Parameters.AddWithValue("NOME", txtNome.Text);
                    cmd.Parameters.AddWithValue("SOBRENOME", txtSobrenome.Text);
                    cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                    conexao.Open();
                    int idJogador = (int)cmd.ExecuteScalar();

                    string nomeCompleto = txtNome.Text.Trim() + " " + txtSobrenome.Text.Trim();

                    if (idJogador > 0)
                    {
                        TelaInstrucoes ti = new TelaInstrucoes(nomeCompleto, idJogador);
                        ti.ShowDialog();
                        Pergunta1 p1 = new Pergunta1(nomeCompleto, idJogador);
                        p1.ShowDialog();
                        Pergunta2 p2 = new Pergunta2(nomeCompleto, idJogador);
                        p2.ShowDialog();
                        Pergunta3 p3 = new Pergunta3(nomeCompleto, idJogador);
                        p3.ShowDialog();
                        Pergunta4 p4 = new Pergunta4(nomeCompleto, idJogador);
                        p4.ShowDialog();
                        TelaFinal tf = new TelaFinal(nomeCompleto, idJogador);
                        tf.ShowDialog();
                    }
                }
            }
        }
    }
}
