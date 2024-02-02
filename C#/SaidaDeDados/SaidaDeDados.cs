using System.Globalization;

char genero = 'f';
int idade = 32;
double saldo = 10.35784;
string nome = "Maria";

//Placeholder
Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais", nome, idade, saldo);

//Interploção
Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reais");

//Concatenação
Console.WriteLine(nome + "tem" + idade + "anos e tem saldo igual a" + saldo.ToString("f2") + " reais ");


//Console.Write("Bom dia!");
//Console.WriteLine("Boa tarde!");
//Console.WriteLine("Boa noite!");
//Console.WriteLine("-----------------------");
//Console.WriteLine(genero);
//Console.WriteLine(idade);
//Console.WriteLine(saldo);
//Console.WriteLine(nome);
//Console.WriteLine(saldo.ToString("F2"));
//Console.WriteLine(saldo.ToString("F3"));
//Console.WriteLine(saldo.ToString("F5", CultureInfo.InvariantCulture ));
