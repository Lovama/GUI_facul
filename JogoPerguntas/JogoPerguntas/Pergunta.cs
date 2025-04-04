public class Pergunta
{
    public string Enunciado { get; set; }
    public string[] Alternativas { get; set; }
    public int RespostaCorreta { get; set; }

    public Pergunta() { }

    public Pergunta(string enunciado, string[] alternativas, int respostaCorreta)
    {
        Enunciado = enunciado;
        Alternativas = alternativas;
        RespostaCorreta = respostaCorreta;
    }
}
