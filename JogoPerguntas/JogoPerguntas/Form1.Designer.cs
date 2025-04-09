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
            this.groupAlternativas = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.labelContador = new System.Windows.Forms.Label();
            this.panelInicio.SuspendLayout();
            this.panelJogo.SuspendLayout();
            this.groupAlternativas.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPergunta
            // 
            this.labelPergunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPergunta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPergunta.Location = new System.Drawing.Point(22, 74);
            this.labelPergunta.Name = "labelPergunta";
            this.labelPergunta.Size = new System.Drawing.Size(400, 80);
            this.labelPergunta.TabIndex = 0;
            this.labelPergunta.Text = "pergunta_aqui";
            this.labelPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPergunta.Click += new System.EventHandler(this.labelPergunta_Click);
            // 
            // rbOpcaoA
            // 
            this.rbOpcaoA.AutoSize = true;
            this.rbOpcaoA.Location = new System.Drawing.Point(6, 45);
            this.rbOpcaoA.Name = "rbOpcaoA";
            this.rbOpcaoA.Size = new System.Drawing.Size(94, 17);
            this.rbOpcaoA.TabIndex = 1;
            this.rbOpcaoA.TabStop = true;
            this.rbOpcaoA.Text = "radioButton1";
            this.rbOpcaoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOpcaoA.UseVisualStyleBackColor = true;
            // 
            // rbOpcaoB
            // 
            this.rbOpcaoB.AutoSize = true;
            this.rbOpcaoB.Location = new System.Drawing.Point(6, 22);
            this.rbOpcaoB.Name = "rbOpcaoB";
            this.rbOpcaoB.Size = new System.Drawing.Size(94, 17);
            this.rbOpcaoB.TabIndex = 2;
            this.rbOpcaoB.TabStop = true;
            this.rbOpcaoB.Text = "radioButton2";
            this.rbOpcaoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOpcaoB.UseVisualStyleBackColor = true;
            // 
            // rbOpcaoC
            // 
            this.rbOpcaoC.AutoSize = true;
            this.rbOpcaoC.Location = new System.Drawing.Point(6, 69);
            this.rbOpcaoC.Name = "rbOpcaoC";
            this.rbOpcaoC.Size = new System.Drawing.Size(94, 17);
            this.rbOpcaoC.TabIndex = 3;
            this.rbOpcaoC.TabStop = true;
            this.rbOpcaoC.Text = "radioButton3";
            this.rbOpcaoC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOpcaoC.UseVisualStyleBackColor = true;
            // 
            // rbOpcaoD
            // 
            this.rbOpcaoD.AutoSize = true;
            this.rbOpcaoD.Location = new System.Drawing.Point(6, 92);
            this.rbOpcaoD.Name = "rbOpcaoD";
            this.rbOpcaoD.Size = new System.Drawing.Size(94, 17);
            this.rbOpcaoD.TabIndex = 4;
            this.rbOpcaoD.TabStop = true;
            this.rbOpcaoD.Text = "radioButton4";
            this.rbOpcaoD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOpcaoD.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.Location = new System.Drawing.Point(190, 310);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.SystemColors.Control;
            this.panelInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInicio.Controls.Add(this.btnSair);
            this.panelInicio.Controls.Add(this.btnDificil);
            this.panelInicio.Controls.Add(this.btnFacil);
            this.panelInicio.Controls.Add(this.labelTitulo);
            this.panelInicio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInicio.Location = new System.Drawing.Point(230, 41);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(318, 387);
            this.panelInicio.TabIndex = 7;
            // 
            // btnDificil
            // 
            this.btnDificil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDificil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDificil.Location = new System.Drawing.Point(194, 229);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(100, 40);
            this.btnDificil.TabIndex = 2;
            this.btnDificil.Text = "Difícil";
            this.btnDificil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDificil.UseVisualStyleBackColor = false;
            this.btnDificil.Click += new System.EventHandler(this.btnDificil_Click_1);
            // 
            // btnFacil
            // 
            this.btnFacil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFacil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacil.Location = new System.Drawing.Point(34, 229);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(100, 40);
            this.btnFacil.TabIndex = 1;
            this.btnFacil.Text = "Fácil";
            this.btnFacil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFacil.UseVisualStyleBackColor = false;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click_1);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(76, 51);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(170, 37);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "QuizMaster";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // panelJogo
            // 
            this.panelJogo.Controls.Add(this.labelContador);
            this.panelJogo.Controls.Add(this.groupAlternativas);
            this.panelJogo.Controls.Add(this.btnVoltar);
            this.panelJogo.Controls.Add(this.labelPergunta);
            this.panelJogo.Controls.Add(this.btnConfirmar);
            this.panelJogo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelJogo.Location = new System.Drawing.Point(180, 65);
            this.panelJogo.Name = "panelJogo";
            this.panelJogo.Size = new System.Drawing.Size(444, 384);
            this.panelJogo.TabIndex = 8;
            // 
            // groupAlternativas
            // 
            this.groupAlternativas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupAlternativas.Controls.Add(this.rbOpcaoA);
            this.groupAlternativas.Controls.Add(this.rbOpcaoC);
            this.groupAlternativas.Controls.Add(this.rbOpcaoB);
            this.groupAlternativas.Controls.Add(this.rbOpcaoD);
            this.groupAlternativas.Location = new System.Drawing.Point(100, 175);
            this.groupAlternativas.Name = "groupAlternativas";
            this.groupAlternativas.Size = new System.Drawing.Size(257, 115);
            this.groupAlternativas.TabIndex = 7;
            this.groupAlternativas.TabStop = false;
            this.groupAlternativas.Text = "Escolha uma alternativa:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Location = new System.Drawing.Point(356, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "MENU";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(110, 332);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 30);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "SAIR";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // labelContador
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.Location = new System.Drawing.Point(27, 22);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(63, 13);
            this.labelContador.TabIndex = 8;
            this.labelContador.Text = "Contagem:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelJogo);
            this.Controls.Add(this.panelInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.panelJogo.ResumeLayout(false);
            this.panelJogo.PerformLayout();
            this.groupAlternativas.ResumeLayout(false);
            this.groupAlternativas.PerformLayout();
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
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupAlternativas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label labelContador;
    }
}

