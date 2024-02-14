//Console.WriteLine("Chute um numero !");
//Random numero = new Random();
//int resultado = numero.Next(10);

//while (true)
//{
//    string chute = Console.ReadLine()!;
//    int tentativa = int.Parse(chute);

//    if (tentativa == resultado)
//    {
//        Console.WriteLine("Seu chute foi " + chute);
//        Console.WriteLine("Parabens vc acertou");
//        break;

//    }
//    else
//    {
//        Console.WriteLine("Seu chute foi " + chute);
//        Console.WriteLine("Errou");
//    }
//}
//////// Desafio calculadora 

//List<int> numerosInt = new List<int> { 1, 2, 3, 4, 5 };

//foreach (var numeros in numerosInt)
//{
//    if (numeros % 2 == 0)
//    {
//        Console.Write(numeros + " ");
//    }
//}
//// DESAFIO DICIONARIO 


/*Dictionary<string, List<int>> alunos = new Dictionary<string, List<int>>();
Alunos.Add("Jean", new List<int> { 7, 10, 9 });
Alunos.Add("Anna", new List<int> { 7, 7, 7 });
Alunos.Add("Luan", new List<int> { 6, 5, 8 });
Alunos.Add("Maria", new List<int> { 8, 7, 5 });

for (int aluno = 0; aluno < alunos.Count; aluno ++)
{
    Console.WriteLine($"A média do aluno {alunos[aluno]} ");
}*/

////string NomeDoAluno = Console.ReadLine()!;
////Console.WriteLine();    
///
Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};
int totalBugatti = 0;
int totalAgera = 0;
int totalLamborghini= 0;
int totalPagani = 0;
int totalFerrari = 0;
List<int> vendasBugatti = vendasCarros["Bugatti Veyron"];
List<int> vendasAgera = vendasCarros["Koenigsegg Agera RS"];
List<int> vendasLamborghini = vendasCarros["Lamborghini Aventador"];
List<int> vendasPagani = vendasCarros["Pagani Huayra"];
List<int> vendasFerrari = vendasCarros["Ferrari LaFerrari"];
for (var venda = 0;venda <vendasCarros.Count;venda++)
{
     
    totalBugatti += vendasBugatti[venda];
    totalAgera += vendasAgera[venda];
    totalLamborghini += vendasLamborghini[venda];
    totalPagani += vendasPagani[venda];
    totalFerrari += vendasFerrari[venda];
}

totalBugatti /= vendasBugatti.Count;
totalAgera /= vendasAgera.Count;
totalLamborghini/=vendasLamborghini.Count;
totalPagani /= vendasPagani.Count;
totalFerrari /= vendasFerrari.Count;
Console.WriteLine($"Vendas do Bugatti Veyron no primeiro mês: {totalBugatti}");
Console.WriteLine($"Vendas do Agera no primeiro mês: {totalAgera}");
Console.WriteLine($"Vendas do Lamborghini  no primeiro mês: {totalLamborghini}");
Console.WriteLine($"Vendas do Pagani no primeiro mês: {totalPagani}");
Console.WriteLine($"Vendas do Ferrari no primeiro mês: {totalFerrari}");


