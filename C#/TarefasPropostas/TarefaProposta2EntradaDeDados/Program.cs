using System.Globalization;

var end = false;
string nome;
int quartos;
double preco;

string[] respostas;

do {
    Console.WriteLine("Entre com seu nome");
    nome = Console.ReadLine();
    Console.WriteLine("Quantos quartos tem na sua casa?");
    quartos = int.Parse(Console.ReadLine());
    Console.WriteLine("Entre com o preço de um produto:");
    preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Entre com seu último nome, idade e altura:");
    respostas = Console.ReadLine().Split(' ');

    string sobreNome = respostas[0];
    int idade = int.Parse(respostas[1]);
    double altura = double.Parse(respostas[2], CultureInfo.InvariantCulture);
    


    Console.WriteLine($"\n\n{nome}\n\n{preco.ToString("f2", CultureInfo.InvariantCulture)}\n\n{sobreNome}" +
        $"\n\n{idade}\n\n{altura.ToString("f2", CultureInfo.InvariantCulture)}");

    end = true;
} while (end == false);
