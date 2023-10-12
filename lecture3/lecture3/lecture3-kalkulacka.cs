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







bool success = false;
int Intcislo1 = 0;
int Intznamenko = 0;
int Intcislo2 = 0;

Console.WriteLine("Napiš číslo");
string cislo1  = Console.ReadLine();
success = int.TryParse(cislo1, out Intcislo1);
if (success == false)
{
    Console.WriteLine("To není číslo!") ;
}

Console.WriteLine("Zvol operaci (+ nebo -)");
string znamenko = Console.ReadLine();
int.TryParse(znamenko, out Intznamenko);

Console.WriteLine("Napiš druhé číslo");
string cislo2  = Console.ReadLine();
int.TryParse(cislo2, out Intcislo2);


if (znamenko == "+") 
{
    int sum = Intcislo1 + Intcislo2;
    Console.WriteLine("výsledek je " + sum);
}
else if (znamenko == "-")
{
    int sum = (Intcislo1 - Intcislo2);
    Console.WriteLine("výsledek je " + sum);
}