// Screen Sound
//string curso = "Aprendendo C#";

//Console.WriteLine(curso);

//string nome = "Jean";
//string sobrenome = "Rocha Santos";

//Console.WriteLine(nome);
//Console.WriteLine(sobrenome);




///////////////////////////////
/////
using System;

string msgBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listasDasBandas = new List<string> { "Charlie Brown","Banda do Mar",
//    "Gilsons","Legião Urbana" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("System of Down", new List<int> { 9,10,9});
bandasRegistradas.Add("Charlie Brown", new List<int>()); 
void ExibirLogo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(msgBoasVindas); 
}
void ExibirOpcoesMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para visualizar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);
  
    switch (opcaoEscolhidaNumero)
        // switch quando houver muitos cenarios ao inves de utilizar vairos if e else if 
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: MediaBanda();
            break;
        case -1: Console.WriteLine("Até a próxima :) "+ opcaoEscolhidaNumero );
            break;
        default: Console.WriteLine("Opção inválida");
            break;
        // Case para escolher oq cada cenario fará
        // default caso nenhum cenario anterior for escolhido
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    ////listasDasBandas.Add(nomeBanda);
    bandasRegistradas.Add(nomeBanda,new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}
void MostrarBandas()
{
    Console.Clear();
    ExibirTituloOpcoes("Exibindo bandas registradas");
    ////for (int posicao = 0;posicao < listasDasBandas.Count; posicao++)
    //{
    //    Console.WriteLine($"Banda : {listasDasBandas[posicao]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)    
    {
        Console.WriteLine($"Banda : {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}
void ExibirTituloOpcoes(string titulo)
{
    int qtdLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(qtdLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos+"\n");
}
void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Avaliar Banda!");
    Console.Write("Digite a banda que quer avaliar: ");
    string nomeDaBanda =Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    /*ContainsKey=Utilizado para verificar se um dicionário contém uma chave específica. Em C#*/
    {
        Console.Write($"Qual nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} da banda {nomeDaBanda} foi registrada com sucesso");
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        string msgErro="Digite A para tentar novamente, ou digite qualquer tecla para retornar ao menu.";
        Console.WriteLine(msgErro);
        string opcaoEscolhida =Console.ReadLine()!.ToUpper();
        Thread.Sleep(2000);        
        if (opcaoEscolhida == "A")
        {
            
            AvaliarBanda();
        } else 
        {     
            ExibirOpcoesMenu();
        } 
    }
}
void MediaBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Média das Bandas");
    Console.WriteLine("Digite o nome da banda: ");
    string nomeBandaConsulta=Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBandaConsulta))
    /*ContainsKey=Utilizado para verificar se um dicionário contém uma chave específica. Em C#*/
    {
        List<int> consultaMedia = bandasRegistradas[nomeBandaConsulta];

        /*indo até as notas da banda e registrando
        int total = 0;
        for (int rodada = 0; rodada < consultaMedia.Count; rodada++)
        {
            total += consultaMedia[rodada];
        }
        total /= consultaMedia.Count;*/

        // MÉTODO AVERAGE  //
        Console.WriteLine($"A média da banda {nomeBandaConsulta} é: {consultaMedia.Average()}");
        /*Console.WriteLine($"A média da banda {nomeBandaConsulta} é: {total}");*/
        Thread.Sleep(2000);
        Console.WriteLine("Digite A para buscar uma média de outra banda," +
            " ou qualquer outra tecla para retornar ao menu.");
        // Average()= um método utilizado para calcular a média de uma coleção de valores numéricos.
        string opcaoEscolhida = Console.ReadLine()!.ToUpper();
        if (opcaoEscolhida == "A")
        {
            MediaBanda();
        }else
        {
            ExibirOpcoesMenu();
        }
    } else
    {
        Console.WriteLine($"\nA banda {nomeBandaConsulta} não foi encontrada");
        string msgErro = "Digite A para tentar novamente, ou digite qualquer tecla para retornar ao menu.";
        Console.WriteLine(msgErro);
        string opcaoEscolhida = Console.ReadLine()!.ToUpper();
        if (opcaoEscolhida == "A") {
            MediaBanda();
        } else
        {
            ExibirOpcoesMenu();
        }
    }
}
ExibirOpcoesMenu();


