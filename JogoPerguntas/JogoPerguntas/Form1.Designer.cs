namespace JogoPerguntas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPergunta = new System.Windows.Forms.Label();
            this.rbOpcaoA = new System.Windows.Forms.RadioButton();
            this.rbOpcaoB = new System.Windows.Forms.RadioButton();
            this.rbOpcaoC = new System.Windows.Forms.RadioButton();
            this.rbOpcaoD = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.btnDificil = new System.Windows.Forms.Button();
            this.btnFacil = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelJogo = new System.Windows.Forms.Panel();
            this.panelInicio.SuspendLayout();
            this.panelJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPergunta
            // 
            this.labelPergunta.AutoSize = true;
            this.labelPergunta.Location = new System.Drawing.Point(115, 51);
            this.labelPergunta.Name = "labelPergunta";
            this.labelPergunta.Size = new System.Drawing.Size(83, 13);
            this.labelPergunta.TabIndex = 0;
            this.labelPergunta.Text = "pergunta_aqui";
            // 
            // rbOpcaoA
            // 
            this.rbOpcaoA.AutoSize = true;
            this.rbOpcaoA.Location = new System.Drawing.Point(118, 192);
            this.rbOpcaoA.Name = "rbOpcaoA";
            this.rbOpcaoA.Size = new System.Drawing.Size(94, 17);
            this.rbOpcaoA.TabIndex = 1;
            this.rbOpcaoA.TabStop = true;
            this.rbOpcaoA.Text = "radioButton1";
            this.rbOpcaoA.UseVisualStyleBackColor = true;
            // 
            // rbOpcaoB
            // 
            this.rbOpcaoB.AutoSize = true;
            this.rbOpcaoB.Location = new System.Drawing.Point(118, 169);
            this.rbOpcaoB.Name = "rbOpcaoB";
            this.rbOpcaoB.Size = new System.Drawing.Size(94, 17);
            this.rbOpcaoB.TabIndex = 2;
            this.rbOpcaoB.TabStop = true;
            this.rbOpcaoB.Text = "radioButton2";
            this.rbOpcaoB.UseVisualStyleBackColor = true;
            // 
            // rbOpcaoC
            // 
            this.rbOpcaoC.AutoSize = true;
            this.rbOpcaoC.Location = new System.Drawing.Point(118, 216);
            this.rbOpcaoC.Name = "rbOpcaoC";
            this.rbOpcaoC.Size = new System.Drawing.Size(94, 17);
            this.rbOpcaoC.TabIndex = 3;
            this.rbOpcaoC.TabStop = true;
            this.rbOpcaoC.Text = "radioButton3";
            this.rbOpcaoC.UseVisualStyleBackColor = true;
            // 
            // rbOpcaoD
            // 
            this.rbOpcaoD.AutoSize = true;
            this.rbOpcaoD.Location = new System.Drawing.Point(118, 239);
            this.rbOpcaoD.Name = "rbOpcaoD";
            this.rbOpcaoD.Size = new System.Drawing.Size(94, 17);
            this.rbOpcaoD.TabIndex = 4;
            this.rbOpcaoD.TabStop = true;
            this.rbOpcaoD.Text = "radioButton4";
            this.rbOpcaoD.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(123, 318);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panelInicio
            // 
            this.panelInicio.Controls.Add(this.btnDificil);
            this.panelInicio.Controls.Add(this.btnFacil);
            this.panelInicio.Controls.Add(this.labelTitulo);
            this.panelInicio.Location = new System.Drawing.Point(107, 152);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(232, 387);
            this.panelInicio.TabIndex = 7;
            // 
            // btnDificil
            // 
            this.btnDificil.Location = new System.Drawing.Point(128, 229);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(75, 23);
            this.btnDificil.TabIndex = 2;
            this.btnDificil.Text = "Difícil";
            this.btnDificil.UseVisualStyleBackColor = true;
            this.btnDificil.Click += new System.EventHandler(this.btnDificil_Click_1);
            // 
            // btnFacil
            // 
            this.btnFacil.Location = new System.Drawing.Point(24, 229);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(75, 23);
            this.btnFacil.TabIndex = 1;
            this.btnFacil.Text = "Fácil";
            this.btnFacil.UseVisualStyleBackColor = true;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click_1);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(88, 64);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(65, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "QuizMaster";
            // 
            // panelJogo
            // 
            this.panelJogo.Controls.Add(this.labelPergunta);
            this.panelJogo.Controls.Add(this.rbOpcaoB);
            this.panelJogo.Controls.Add(this.btnConfirmar);
            this.panelJogo.Controls.Add(this.rbOpcaoA);
            this.panelJogo.Controls.Add(this.rbOpcaoD);
            this.panelJogo.Controls.Add(this.rbOpcaoC);
            this.panelJogo.Location = new System.Drawing.Point(463, 165);
            this.panelJogo.Name = "panelJogo";
            this.panelJogo.Size = new System.Drawing.Size(313, 384);
            this.panelJogo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 577);
            this.Controls.Add(this.panelJogo);
            this.Controls.Add(this.panelInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.panelJogo.ResumeLayout(false);
            this.panelJogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPergunta;
        private System.Windows.Forms.RadioButton rbOpcaoA;
        private System.Windows.Forms.RadioButton rbOpcaoB;
        private System.Windows.Forms.RadioButton rbOpcaoC;
        private System.Windows.Forms.RadioButton rbOpcaoD;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Panel panelJogo;
        private System.Windows.Forms.Button btnDificil;
        private System.Windows.Forms.Button btnFacil;
        private System.Windows.Forms.Label labelTitulo;
    }
}

