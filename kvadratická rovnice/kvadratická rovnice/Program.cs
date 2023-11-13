do
{
    bool success1 = false;
    bool success2 = false;
    bool success3 = false;
    bool success4 = false;
    double IntcisloA = 0;
    double IntcisloB = 0;
    double IntcisloC = 0;
    double IntcisloX = 0;

    Console.WriteLine("řešení kvadratické rovnice");
    Console.WriteLine("a*x*x+b*x+c=0");

    do
    {
        Console.WriteLine("zadej číslo A");
        string cisloA = Console.ReadLine();
        success1 = double.TryParse(cisloA, out IntcisloA);
        if (success1 == false)
        {
            Console.WriteLine("Tohle není číslo!");
        }
    }
    while (!success1);

    do
    {
        Console.WriteLine("zadej číslo B");
        string cisloB = Console.ReadLine();
        success2 = double.TryParse(cisloB, out IntcisloB);
        if (success2 == false)
        {
            Console.WriteLine("Tohle není číslo!");
        }
    }
    while (!success2);

    do
    {
        Console.WriteLine("zadej číslo C");
        string cisloC = Console.ReadLine();
        success3 = double.TryParse(cisloC, out IntcisloC);
        if (success3 == false)
        {
            Console.WriteLine("Tohle není číslo!");
        }
    }
    while (!success3);

    double diskriminant = IntcisloB * IntcisloB - 4 * IntcisloA * IntcisloC;

    if (IntcisloA == 0)
    {
        Console.WriteLine("To není kvadratická rovnice.");
    }

    else if (diskriminant < 0)
    {
        Console.WriteLine("Rovnice nemá řešení");
    }

    else if (diskriminant == 0)
    {
        Console.WriteLine("Rovnice má jedno řešení.");
        Console.WriteLine("Výsledek je  x=" + -IntcisloB / (2 * IntcisloA));
    }

    else
    {
        Console.WriteLine("Rovnice má dvě řešení.");
        Console.WriteLine("Výsledek je  x1=" + ((-IntcisloB + Math.Sqrt(IntcisloB * IntcisloB - 4 * IntcisloA * IntcisloC)) / (2 * IntcisloA)));
        Console.WriteLine("Výsledek je  x2=" + ((-IntcisloB - Math.Sqrt(IntcisloB * IntcisloB - 4 * IntcisloA * IntcisloC)) / (2 * IntcisloA)));
    }




    Console.WriteLine("Ukončit program? (ano/ne)");
    string AnoNe1 = Console.ReadLine();

    if (AnoNe1 == "ano")
    {
        Console.WriteLine("Dobře");
        break;
    }

    do
    {
        do
        {
            Console.WriteLine("Dosaď x do funkce " + IntcisloA + "*x*x + " + IntcisloB + "*x + " + IntcisloC + " = 0");
            string cisloX = Console.ReadLine();
            success4 = double.TryParse(cisloX, out IntcisloX);
            if (success4 == false)
            {
                Console.WriteLine("Tohle není číslo!");
            }
        }
        while (!success4);

        double vysledek = IntcisloA * IntcisloX * IntcisloX + IntcisloB * IntcisloX + IntcisloC;

        Console.WriteLine("Výsledek je " + vysledek);

        Console.WriteLine("Přeješ si vypočítat novou rovnici? (ano/ne)");
        string AnoNe2 = Console.ReadLine();

        if (AnoNe2 == "ano")
        {
            Console.WriteLine("Dobře");
            break;
        }
    }
    while (true);

    Console.WriteLine("Ukončit program?");
    string AnoNe = Console.ReadLine();

    if (AnoNe == "ano")
    {
        Console.WriteLine("Dobře");
        break;
    }

}
while (true);
