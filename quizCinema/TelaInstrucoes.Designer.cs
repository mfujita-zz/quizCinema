namespace quizCinema
{
    partial class TelaInstrucoes
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
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.lblInstrucoes = new System.Windows.Forms.Label();
            this.btnVamosLa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Location = new System.Drawing.Point(59, 43);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(35, 13);
            this.lblBoasVindas.TabIndex = 0;
            this.lblBoasVindas.Text = "label1";
            // 
            // lblInstrucoes
            // 
            this.lblInstrucoes.AutoSize = true;
            this.lblInstrucoes.Location = new System.Drawing.Point(62, 88);
            this.lblInstrucoes.Name = "lblInstrucoes";
            this.lblInstrucoes.Size = new System.Drawing.Size(35, 13);
            this.lblInstrucoes.TabIndex = 1;
            this.lblInstrucoes.Text = "label1";
            // 
            // btnVamosLa
            // 
            this.btnVamosLa.Location = new System.Drawing.Point(328, 199);
            this.btnVamosLa.Name = "btnVamosLa";
            this.btnVamosLa.Size = new System.Drawing.Size(115, 23);
            this.btnVamosLa.TabIndex = 2;
            this.btnVamosLa.Text = "Ok, vamos lá!";
            this.btnVamosLa.UseVisualStyleBackColor = true;
            this.btnVamosLa.Click += new System.EventHandler(this.btnVamosLa_Click);
            // 
            // TelaInstrucoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quizCinema.Properties.Resources.cinema3;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.btnVamosLa);
            this.Controls.Add(this.lblInstrucoes);
            this.Controls.Add(this.lblBoasVindas);
            this.Name = "TelaInstrucoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInstrucoes";
            this.Load += new System.EventHandler(this.TelaInstrucoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Label lblInstrucoes;
        private System.Windows.Forms.Button btnVamosLa;
    }
}