using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JogoPerguntas
{
    public partial class Form1 : Form
    {
        private List<Pergunta> perguntas;
        private int perguntaAtual = 0;

        public Form1()
        {
            InitializeComponent();
            MostrarTelaInicial();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFacil.BackColor = Color.LightGreen;
            btnDificil.BackColor = Color.LightCoral;
            btnConfirmar.BackColor = Color.LightBlue;
            btnVoltar.BackColor = Color.LightGray;
            btnSair.BackColor = Color.LightGray;
        }

        private void MostrarTelaInicial()
        {
            panelInicio.Visible = true;
            panelJogo.Visible = false;
        }

        private void MostrarJogo()
        {
            panelInicio.Visible = false;
            panelJogo.Visible = true;
            ExibirPergunta();
        }

        private void btnFacil_Click_1(object sender, EventArgs e)
        {
            perguntas = CarregarPerguntas("perguntas_faceis.json");
            MostrarJogo();
        }

        private void btnDificil_Click_1(object sender, EventArgs e)
        {
            perguntas = CarregarPerguntas("perguntas_dificeis.json");
            MostrarJogo();
        }

        private List<Pergunta> CarregarPerguntas(string caminho)
        {
            string json = File.ReadAllText(caminho); // UTF-8 é o padrão aqui
            return JsonConvert.DeserializeObject<List<Pergunta>>(json);
        }

        private void ExibirPergunta()
        {
            if (perguntaAtual >= perguntas.Count)
            {
                MessageBox.Show("Fim do quiz!");
                MostrarTelaInicial();
                perguntaAtual = 0;
                return;
            }

            Pergunta p = perguntas[perguntaAtual];
            labelPergunta.Text = p.Enunciado;

            RadioButton[] opcoes = { rbOpcaoA, rbOpcaoB, rbOpcaoC, rbOpcaoD };
            for (int i = 0; i < opcoes.Length; i++)
            {
                opcoes[i].Text = p.Alternativas[i];
                opcoes[i].Checked = false;
                opcoes[i].BackColor = SystemColors.Control;
            }

            labelContador.Text = $"Pergunta {perguntaAtual + 1} de {perguntas.Count}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int respostaSelecionada = -1;

            if (rbOpcaoA.Checked) respostaSelecionada = 0;
            else if (rbOpcaoB.Checked) respostaSelecionada = 1;
            else if (rbOpcaoC.Checked) respostaSelecionada = 2;
            else if (rbOpcaoD.Checked) respostaSelecionada = 3;

            if (respostaSelecionada == -1)
            {
                MessageBox.Show("Por favor, selecione uma alternativa antes de confirmar.");
                return;
            }

            int respostaCorreta = perguntas[perguntaAtual].RespostaCorreta;
            MarcarRespostas(respostaSelecionada, respostaCorreta);
        }

        private void MarcarRespostas(int selecionada, int correta)
        {
            RadioButton[] opcoes = { rbOpcaoA, rbOpcaoB, rbOpcaoC, rbOpcaoD };

            for (int i = 0; i < opcoes.Length; i++)
            {
                if (i == correta)
                    opcoes[i].BackColor = Color.LightGreen;
                else if (i == selecionada)
                    opcoes[i].BackColor = Color.LightCoral;
                else
                    opcoes[i].BackColor = SystemColors.Control;
            }

            // Esperar 1 segundo antes de passar para a próxima
            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                perguntaAtual++;
                ExibirPergunta();
            };
            timer.Start();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            perguntaAtual = 0;
            MostrarTelaInicial();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelPergunta_Click(object sender, EventArgs e)
        {
            // vazio
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
