// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programa para pedir la nota de un estudiante y mostrar que aprobo (mas de 70), recuperacion (50-69) o reprueba (menos de 50) con switch case");
int nota;
Console.WriteLine("Ingrese la nota del estudiante");
nota = Convert.ToInt32(Console.ReadLine());
switch (nota) //Obtiene como parametro el valor de nota
{
    case int n when (n >= 70):
        Console.WriteLine("El estudiante aprobo");
        break;
    case int n when (n >= 50 && n < 70):
        Console.WriteLine("El estudiante debe ir a reparacion");
        break;
    default:
        Console.WriteLine("El estudiante reprueba");
        break;
}
