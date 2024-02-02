using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";
double conversaoExplicita = 650.50;

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
float preco2 = (float)conversaoExplicita;
double medida = 53.234567;

Console.WriteLine($"\n\n Produtos:\n {produto1}, cujo proço é ${preco1:f2}\n {produto2}, cujo preço é ${preco2:f2}\n\n" +
    $" Registro: {idade} anos de idade, código {codigo} e gênero:{genero}\n\n" +
    $" Medida com oito casas decimais:{medida:f8}\n" +
    $" Arredondado (três casas decimais): {medida:f3}\n" +
    $" Separador decimal invarint culture:"+ medida.ToString("f3", CultureInfo.InvariantCulture));