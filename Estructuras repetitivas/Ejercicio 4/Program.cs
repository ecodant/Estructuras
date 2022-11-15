int n = 1, sum = 0, prom = 0, nValues = 0;
while (n != 0)
{
    Console.WriteLine("Ingrese un número");
    if (int.TryParse(Console.ReadLine(), out n))
    {
        if (n > 0)
        {
            sum += n;
            nValues++;
            prom = sum / nValues;
        }
    }
    else
    {
        n = 1;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error, no ingreso un número");
        Console.ResetColor();
    }
}

Console.WriteLine($"La suma de los valores ingresados es: {sum} y el promedio es: {prom}");
