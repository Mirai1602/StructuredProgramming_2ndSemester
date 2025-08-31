// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programa que lee los numeros del teclado mientras no se digite -99. Determinar el mayor y menor de los numeros");
string sentencia = -99;
int Mayor;
int menor;
int i = 0;
while (sentencia != -99)
{
    Console.WriteLine("Ingrese un numero:");
    sentencia = Convert.ToInt32(Console.ReadLine());
    if (i == 0)
    {
        Mayor = sentencia;
        menor = sentencia;
    }
    else
    {
        if (sentencia > Mayor)
        {
            Mayor = sentencia;
        }
        if (sentencia < menor)
        {
            menor = sentencia;
        }
    }
    i++;
}
Console.WriteLine("El mayor es: " + Mayor);
Console.WriteLine("El menor es: " + menor);