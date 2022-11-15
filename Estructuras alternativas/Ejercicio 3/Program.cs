    int[] numbers= new int[3];
    Console.WriteLine("Ingrese primer numero");
    numbers[0] = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese segundo numero");
    numbers[1] = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese tercer numero");
    numbers[2] = int.Parse(Console.ReadLine());
    
    Array.Sort(numbers);
    Array.Reverse(numbers);

        for (int i = 0; i < 3;i++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(numbers[i] + " ");
            Console.ResetColor();
        }
        Console.Write("\n");