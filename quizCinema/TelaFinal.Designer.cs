namespace quizCinema
{
    partial class TelaFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.btnJogarDeNovo = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(35, 13);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "label1";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "label1";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Location = new System.Drawing.Point(12, 100);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(35, 13);
            this.lblPontos.TabIndex = 2;
            this.lblPontos.Text = "label1";
            // 
            // btnJogarDeNovo
            // 
            this.btnJogarDeNovo.Location = new System.Drawing.Point(60, 218);
            this.btnJogarDeNovo.Name = "btnJogarDeNovo";
            this.btnJogarDeNovo.Size = new System.Drawing.Size(123, 23);
            this.btnJogarDeNovo.TabIndex = 3;
            this.btnJogarDeNovo.Text = "Jogar de novo";
            this.btnJogarDeNovo.UseVisualStyleBackColor = true;
            this.btnJogarDeNovo.Click += new System.EventHandler(this.btnJogarDeNovo_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(498, 218);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(123, 23);
            this.btnEncerrar.TabIndex = 4;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // TelaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quizCinema.Properties.Resources.cinema4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnJogarDeNovo);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMensagem);
            this.Name = "TelaFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFinal";
            this.Load += new System.EventHandler(this.TelaFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Button btnJogarDeNovo;
        private System.Windows.Forms.Button btnEncerrar;
    }
}