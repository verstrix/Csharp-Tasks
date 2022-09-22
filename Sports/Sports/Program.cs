
    Console.WriteLine("Enter your height");
    int height = int.Parse(Console.ReadLine());

    if (height >= 190)
    {
        Console.WriteLine("Basketball will be the perfect sport for you");
    }
    else if ((height >= 175) && (height < 190))
    {
        Console.WriteLine("Looks like athletics will be the perfect sport for you");
    }
    if (height < 175)
    {
        Console.WriteLine("Horse riding will be the best sport for you");
    }
