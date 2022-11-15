int nMayor = 0, nMenor = 0;

Console.WriteLine("Ingrese el primer número");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
int n2 = int.Parse(Console.ReadLine());
if (n1 == n2)
{
    Console.WriteLine("Los números son iguales");
}
else if (n1 > n2)
{
    nMayor= n1;
    nMenor= n2;
}
else
{
    nMayor= n2;
    nMenor= n1;
}
Console.WriteLine("Los números pares entre los números que proporcionó son: ");
Console.ForegroundColor = ConsoleColor.Green;
for (int i = nMenor; i <= nMayor; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
}
Console.ResetColor();
Console.Write("\n");