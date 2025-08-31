// See https://aka.ms/new-console-template for more information
Console.WriteLine("Este programa nos permite determinar si un año es bisiesto o no");
int year;
Console.WriteLine("Por favor ingresa un año:");
year = Convert.ToInt32(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine("El año " + year + " es bisiesto.");
}
else
{
    Console.WriteLine("El año " + year + " no es bisiesto.");
}
