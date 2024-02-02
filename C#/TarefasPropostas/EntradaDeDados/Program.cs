using System.Globalization;


Console.Write("Enter a number (1-3): ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("You entered one.");
        break;

    case 2:
        Console.WriteLine("You entered two.");
        break;

    case 3:
        Console.WriteLine("You entered three.");
        break;

    default:
        Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        break;
}

        string frase = "O Paulo é viado?";

Console.WriteLine(frase);

var confirmacao = Console.ReadLine();

do
{
 
    if (confirmacao == "sim")
    {
        frase = "Então me da o cuzinho";
        break;
    }
    else
    {
        frase = "Não mente e me da o cuzinho";
        break;
    }
}
while (confirmacao != null);




Console.WriteLine($"\n\n\n\n\n\n{frase}");