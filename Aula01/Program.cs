string LerEntrada(string mensagem, ref bool continuar)
{
    Console.WriteLine(mensagem);
    string entrada = Console.ReadLine()?.Trim() ?? string.Empty;

    if (entrada.ToLower() == "sair")
    {
        continuar = false;
        Console.WriteLine("Encerrando o chat... Valeu!");
    }

    return entrada;
}

bool continuar = true;

while (continuar)
{
    string input = LerEntrada("Digite 'sair' para encerrar o chat do bot ou pressione Enter para continuar.", ref continuar);
    if (!continuar) break;

    Console.WriteLine("\n--------------------------------\n");

    string nome = LerEntrada("Salve! Qual é seu nome?", ref continuar);
    if (!continuar) break;

    string idade = LerEntrada($"Bot: Muito prazer em te conhecer, {nome}! Quantos anos cê tem?", ref continuar);
    if (!continuar) break;

    string resposta = LerEntrada("Você aprendeu a salvar as respostas?", ref continuar).ToLower();
    if (!continuar) break;

    if (resposta == "sim")
    {
        Console.WriteLine("Parabéns, você tá ficando bom em C#!");
    }
    else if (resposta == "não")
    {
        Console.WriteLine("Não tem problema, você vai aprender!");
    }
    else
    {
        Console.WriteLine("BOT: Não entendi o que você disse, mas continue tentando 😅");
    }

    string nivel = LerEntrada($"\nMe fala aí o seu nível de aprendizagem em C#, {nome}:", ref continuar).ToLower();
    if (!continuar) break;

    if (nivel == "iniciante")
    {
        Console.WriteLine("Boa moleque, continua praticando que vai dar bom!");
    }
    else if (nivel == "intermediário")
    {
        Console.WriteLine("Muito bem, você já tá mandando muito!");
    }
    else
    {
        Console.WriteLine("Você é o cara, fio! Tá voando!");
    }

    int pontos = 0;

    Console.WriteLine("Bora ver se você sabe sobre o game League Of Legends?");
    Console.WriteLine("Qual Personagem tem a fala, tem um gosto meio roxo?");
    Console.WriteLine("a) Velkoz   b) Varus   c) Lulu  d) Leblanc");

    string respostaQuiz = LerEntrada("", ref continuar).ToLower();
    if (!continuar) break;

    if (respostaQuiz == "c" || respostaQuiz == "lulu")
    {
        Console.WriteLine("Acertou em seu viciadinho");
        pontos++;
    }
    else
    {
        Console.WriteLine("Errou lazarento A resposta certa era: Lulu");
    }

    Console.WriteLine($"Você fez {pontos} ponto(s) no quiz!");

    Console.WriteLine("\n--------------------------------\n");

    Console.WriteLine("Avalie meu bot simples feito em C#:");
    Console.WriteLine("1 - Muito Bom");
    Console.WriteLine("2 - Bom");
    Console.WriteLine("3 - Da pra melhorar");
    int avaliacao2 = int.Parse(LerEntrada("", ref continuar));
    if (!continuar) break;

    switch (avaliacao2)
    {
        case 1:
            Console.WriteLine("Valeu, você é a lenda!");
            break;
        case 2:
            Console.WriteLine("Obrigado pela avaliação, estarei melhorando");
            break;
        case 3:
            Console.WriteLine("Vou me esforçar mais");
            break;
        default:
            Console.WriteLine("Não entendi sua avaliação, mas valeu mesmo assim!");
            break;
    }

    Console.WriteLine("\n--------------------------------\n");
}
