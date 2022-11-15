int nota, age;
string sex;

Console.WriteLine("Ingrese la nota como entero porfavor");
nota = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la edad como entero porfavor");
age = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su sexo, 'M' para masculino y 'F' para femenino");
sex = (Console.ReadLine());

if (nota >= 5 && age >= 18)
{
    if (sex == "F" || sex == "f")
    {
        Console.WriteLine("ACEPTADA");
    }
    else if (sex == "M" || sex == "m")
    {
        Console.WriteLine("POSIBLE");
    }
}
else
{
    Console.WriteLine("NO ACEPTADA");
}
