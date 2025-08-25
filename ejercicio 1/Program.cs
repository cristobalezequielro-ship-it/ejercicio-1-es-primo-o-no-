// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dame un número:");
int numero = int.Parse(Console.ReadLine());

bool esPrimo = true;
var noPrrimo = false;
if (numero <= 2)
{
    esPrimo = false;
}
else
{
    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0) // si hay un divisor
        {
            esPrimo = false;
            break;
        }
    }
}

if (esPrimo)
{
    Console.WriteLine("El número " + numero + " es primo.");
}
else
{
    Console.WriteLine("El número " + numero + " no es primo.");
}
