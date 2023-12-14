
while (true)
{
    string[] tvary = new string[] { "čtverec", "obdelník", "kružnice", "trojúhelník", "krychle", "kvádr", "koule", "jehlan"};

    void vyber()
    {
        Console.WriteLine("KALKULAČKA ÚTVARŮ");
        Console.WriteLine();

        for (int i = 0; i < tvary.Length; i++)
        {
 
            Console.WriteLine(i+1 + ") " + tvary[i]);
        }
    }

  
    vyber();
    Console.WriteLine();   
    Console.WriteLine("Zvol si tvar (čislo):");

    bool success = false;

    do
    {
        int cislo;
        
        if (success=int.TryParse(Console.ReadLine(), out cislo) || (cislo > 0 || cislo < 9))
        {

            switch (cislo)
            {
                case 1:
                    PrintSquare();
                    break;

                case 2:
                    PrintRectangle();
                    break;

                case 3:
                    PrintSphere();
                    break;

                case 4:
                    PrintTriangle();
                    break;

                case 5:
                    PrintCube();
                    break;

                case 6:
                    PrintBlock();
                    break;

                case 7:
                    PrintGlobe();
                    break;

                case 8:
                    PrintCone();
                    break;

              

            }
        }

        if (success == true)
        {
            Console.WriteLine("Neplatný vstup. Zadej prosím platné číslo (1-8).");
        }

    }
    while (!success);
 


    Console.WriteLine("Přeješ si skončit?");
    string konec = Console.ReadLine();
    
    if (konec == "ano")
    {
        break;
    }
 
       
    
    double strany(string koeficient)
    {
        while (true)
        {
            Console.WriteLine("Zadej délku strany " + koeficient);
            string strana = Console.ReadLine();

            if (double.TryParse(strana, out double x) && x > 0)
            {
                return x;
            }
 
 
            else
            {
                Console.WriteLine("Zadej jiné číslo");
            }
        }
    }
 
   
    void PrintSquare()
    {
        while (true)
        {
            double a = strany("a");
 
            Console.WriteLine("Obvod = " + a * 4);
            Console.WriteLine("Obsah = " + a * a);
            break;
        }
    }
   
    
    void PrintRectangle()
    {
        while (true)
        {
            double a = strany("a");
            double b = strany("b");
 
            Console.WriteLine("Obvod = " + (a * 2 + b * 2));
            Console.WriteLine("Obsah = " + a * b);
            break;
        }
    }
       
    
    void PrintSphere()
    {
        while (true)
        {
            double r = strany("r");
 
            Console.WriteLine("Obvod = " + 2 * Math.PI * r);
            Console.WriteLine("Obsah = " + Math.PI * r * r);
            break;
        }
    }
        
    
    void PrintTriangle()
    {         
        while (true)
        {                
            double a = strany("a");
            double b = strany("b");
            double c = strany("c");
 
            if ((a + b > c) && (b + c > a) && (c + a > b))
            {
                double x = (a + b + c) / 2;
                double y = x * (x - a) * (x - b) * (x - c);
                double obsah = Math.Sqrt(y);
                double obvod = a + b + c;
 
                Console.WriteLine("Obvod = " + obvod);
                Console.WriteLine("Obsah = " + obsah);
                break;
            }
                
            else
            {
                Console.WriteLine("To není platný trojúhelník");
            }
        }
    }
        
    
    void PrintCube()
    {           
        while (true)
        {
            double a = strany("a");
                 
            Console.WriteLine("Povrch = " + a * a * 6);
            Console.WriteLine("Objem = " + a * a * a);
            break;
        }
    }
        
    
    void PrintBlock()
    {            
        while (true)
        {                
            double a = strany("a");
            double b = strany("b");
            double c = strany("c");
                 
            Console.WriteLine("Povrch = " + (2 * (a * b + b * c + a * c)));
            Console.WriteLine("Objem = " + a * b * c);
            break;
        }
    }
         
    
    void PrintGlobe()
    {           
        while (true)
        {                
            double r = strany("r");
 
            Console.WriteLine("Povrch = " + 4 * Math.PI * r * r);
            Console.WriteLine("Objem = " + ((4* Math.PI * r*r*r)/3));
            break;
        }
    }
        
    
    void PrintCone()
    {            
        while (true)
        {                
            double r = strany("r");
            double v = strany("v");
 
            double p = r * r + v * v;
            double delka = Math.Sqrt(p);
            double povrch = (Math.PI * r * r) + (Math.PI * r * delka);
            double objem = Math.PI * r * r * v / 3;

            Console.WriteLine("Povrch = " +  povrch);
            Console.WriteLine("Objem = " + objem);
            break;
        }
    }
}
