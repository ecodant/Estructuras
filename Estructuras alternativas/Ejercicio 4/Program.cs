int a,b,c;

Console.WriteLine("Ingrese el valor A del traingulo");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor B del traingulo");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor C del traingulo");
c = int.Parse(Console.ReadLine());
if (((a*a) + (b*b)) == (c*c))
{
    Console.WriteLine("Es un triangulo rectangulo"); 
}

else if((a == b && a != c) || (a == c && a != b))
{
    Console.WriteLine("Es un triangulo isósceles"); 
}

else if (a == b && b == c)
{
    Console.WriteLine("Es un triangulo Equilatero"); 
}

else 
{
    Console.WriteLine("Es un triangulo escaleno"); 
}