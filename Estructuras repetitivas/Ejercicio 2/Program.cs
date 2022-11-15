int n, intentos = 10;
Random randomNumber = new Random();
int guess = randomNumber.Next(1,101);

// Console.WriteLine(guess);
while (intentos > 0)
{ 
    Console.WriteLine("Ingrese un número del 1 al 100");
    if (int.TryParse(Console.ReadLine(), out n))
    {
        if(n == guess)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"Felicidades ha acertado!!, con {11 - intentos} intentos");
            Console.ResetColor();
            intentos = 0;
        }
        else if (n > guess)
        {
            Console.WriteLine($"Usted ingreso {n}, el número a adivinar era menor que el ingresado");
            intentos--;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Le quedan {intentos} intentos");
            Console.ResetColor(); 
        }
        else
        {
            Console.WriteLine($"Usted ingreso {n}, el número a adivinar era mayor que el ingresado");
            intentos--;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Le quedan {intentos} intentos");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error, por favor, ingrese un número entero");
        Console.ResetColor();
    }
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"El número era {guess}");
Console.ResetColor();