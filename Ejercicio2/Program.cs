// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programa para pedir la nota de un estudiante y mostrar que aprobo (mas de 70), recuperacion (50-69) o reprueba (menos de 50)");
int nota;
Console.WriteLine("Ingrese la nota del estudiante");
nota = Convert.ToInt32(Console.ReadLine());
if (nota >= 70)
{
    Console.WriteLine("El estudiante está en aprobo");
}
else if (nota >= 50 && nota < 70)
{
    Console.WriteLine("EL estudiante debe ir a reparacion");
}
else
{
    Consoloe.WriteLine("El estudiante reprueba");
}

