int n;
long factorial = 1;
bool validate = false;

while (!validate)
{
    Console.WriteLine("Ingrese un valor entero positivo para averiguar su respectivo factorial");

    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Operación completada → {n}! = {factorial}");
        Console.ResetColor();
        validate = true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("**ERROR, POR FAVOR, INGRESE UN VALOR VALIDO");
        Console.ResetColor();
    }
}