namespace quizCinema
{
    partial class Pergunta1
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
            this.lblNomeSobrenome = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblPergunta1 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.btn01_02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeSobrenome
            // 
            this.lblNomeSobrenome.AutoSize = true;
            this.lblNomeSobrenome.Location = new System.Drawing.Point(13, 9);
            this.lblNomeSobrenome.Name = "lblNomeSobrenome";
            this.lblNomeSobrenome.Size = new System.Drawing.Size(35, 13);
            this.lblNomeSobrenome.TabIndex = 0;
            this.lblNomeSobrenome.Text = "label1";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(13, 39);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(59, 13);
            this.lblP1.TabIndex = 1;
            this.lblP1.Text = "Pergunta 1";
            // 
            // lblPergunta1
            // 
            this.lblPergunta1.AutoSize = true;
            this.lblPergunta1.Location = new System.Drawing.Point(13, 72);
            this.lblPergunta1.Name = "lblPergunta1";
            this.lblPergunta1.Size = new System.Drawing.Size(35, 13);
            this.lblPergunta1.TabIndex = 2;
            this.lblPergunta1.Text = "label1";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(16, 105);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(85, 17);
            this.rb1.TabIndex = 3;
            this.rb1.TabStop = true;
            this.rb1.Text = "radioButton1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(16, 137);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(85, 17);
            this.rb2.TabIndex = 4;
            this.rb2.TabStop = true;
            this.rb2.Text = "radioButton1";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(16, 169);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(85, 17);
            this.rb3.TabIndex = 5;
            this.rb3.TabStop = true;
            this.rb3.Text = "radioButton2";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(16, 202);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(85, 17);
            this.rb4.TabIndex = 6;
            this.rb4.TabStop = true;
            this.rb4.Text = "radioButton3";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // btn01_02
            // 
            this.btn01_02.Location = new System.Drawing.Point(336, 233);
            this.btn01_02.Name = "btn01_02";
            this.btn01_02.Size = new System.Drawing.Size(126, 23);
            this.btn01_02.TabIndex = 7;
            this.btn01_02.Text = "Ir para pergunta 2";
            this.btn01_02.UseVisualStyleBackColor = true;
            this.btn01_02.Click += new System.EventHandler(this.btn01_02_Click);
            // 
            // Pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.btn01_02);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lblPergunta1);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lblNomeSobrenome);
            this.Name = "Pergunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta1";
            this.Load += new System.EventHandler(this.Pergunta1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeSobrenome;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblPergunta1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Button btn01_02;
    }
}