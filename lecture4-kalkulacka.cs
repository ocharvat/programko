//for (int i = 0; i < 20; i++)
//{
//    Console.Write(i + "  ");  
//Console.WriteLine(i % 3);
//}








//for (int i = 1; i < 101; i++)
//{
//    if (i % 7 == 0 && i % 9 == 0)
//    {
//        Console.WriteLine("fizzbuzz");
//    }
//    else if (i % 9 == 0)
//    {
//        Console.WriteLine("buzz");
//    }
//    else if (i % 7 == 0)
//    {
//       Console.WriteLine("fizz");
//    }

//    else Console.WriteLine(i);

//}







bool success1 = false;
bool successZ = false;
bool success2 = false;
double Intcislo1 = 0;
double Intcislo2 = 0;
string operace;

while (true)
{
            do
            {
                Console.WriteLine("Napiš číslo");
                string cislo1 = Console.ReadLine();
                success1 = double.TryParse(cislo1, out Intcislo1);
                    if (success1 == false)
                    {
                        Console.WriteLine("To není číslo!");
                    }
            }
            while (!success1);

            do
            {
                Console.WriteLine("Zvol operaci (+,-,*,/)");
                operace = Console.ReadLine();
                successZ = operace=="+"||operace=="-" || operace == "*" || operace == "/";
                    if (successZ == false)
                        {
                            Console.WriteLine("To není platná operace!");
                        }

            }
            while (!successZ);


            do
            {
                Console.WriteLine("Napiš druhé číslo");
                string cislo2  = Console.ReadLine();
                success2 = double.TryParse(cislo2, out Intcislo2);
                    if (success2 == false)
                    {
                        Console.WriteLine("To není číslo!");
                    }
            }
            while (!success2);



            if (operace == "+") 
            {
                double sum = Intcislo1 + Intcislo2;
                Console.WriteLine("výsledek je " + sum);
            }
            else if (operace == "-")
            {
                double sum = (Intcislo1 - Intcislo2);
                Console.WriteLine("výsledek je " + sum);
            }
            else if(operace == "*") 
            {
                double sum = Intcislo1 * Intcislo2;
                Console.WriteLine("výsledek je " + sum);
            }
            else if (operace == "/")
            {
                double sum = Intcislo1 / Intcislo2;
                Console.WriteLine("výsledek je " + sum);
            }


    Console.WriteLine("Ukončit program?");
    string opakování = Console.ReadLine();
    if (opakování == "ano")
    {
        break;
    }


}



