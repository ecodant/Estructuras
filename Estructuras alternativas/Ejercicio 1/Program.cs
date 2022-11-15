int e, n;
bool vali = false;
while (vali == false)
{

    Console.WriteLine("Ingrese un número base para calcular su potencia");
    string? inputN = Console.ReadLine();
    Console.WriteLine("Ingrese el exponente para calcular la potencia");
    string? inputE = Console.ReadLine();
    if (int.TryParse(inputN, out n) == true && int.TryParse(inputE, out e) == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"La potencia del número es: {Math.Pow(n, e)}");
        Console.ResetColor();
        vali = true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR, Por favor, ingrese números en los valores solicitados");
        Console.ResetColor();
    }
}