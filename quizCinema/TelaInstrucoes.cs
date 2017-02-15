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
    public partial class TelaInstrucoes : Form
    {
        string nomeCompleto = "";
        int id;

        public TelaInstrucoes(string nomeJogador, int idJogador)
        {
            InitializeComponent();
            nomeCompleto = nomeJogador;
            id = idJogador;
        }

        private void TelaInstrucoes_Load(object sender, EventArgs e)
        {
            lblBoasVindas.Text = "Bem-vindo, " + nomeCompleto + "!";

            lblInstrucoes.Text = "Você responderá 4 questões sendo os níveis: fácil, moderado e difícil envolvendo assuntos de cinema. \nBom desafio!";
        }

        private void btnVamosLa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
