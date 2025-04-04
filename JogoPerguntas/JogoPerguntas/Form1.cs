using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
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
            string json = File.ReadAllText(caminho);
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
            rbOpcaoA.Text = p.Alternativas[0];
            rbOpcaoB.Text = p.Alternativas[1];
            rbOpcaoC.Text = p.Alternativas[2];
            rbOpcaoD.Text = p.Alternativas[3];

            rbOpcaoA.Checked = false;
            rbOpcaoB.Checked = false;
            rbOpcaoC.Checked = false;
            rbOpcaoD.Checked = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int respostaSelecionada = -1;

            if (rbOpcaoA.Checked) respostaSelecionada = 0;
            else if (rbOpcaoB.Checked) respostaSelecionada = 1;
            else if (rbOpcaoC.Checked) respostaSelecionada = 2;
            else if (rbOpcaoD.Checked) respostaSelecionada = 3;

            if (respostaSelecionada == perguntas[perguntaAtual].RespostaCorreta)
            {
                MessageBox.Show("Resposta correta!");
            }
            else
            {
                MessageBox.Show("Resposta errada!");
            }

            perguntaAtual++;
            ExibirPergunta();
        }
    }
}
