//double PlusJedna(double x)
//{
//    return x + 1;
//}

//double x = 3;

//double y = PlusJedna(x);

//Console.WriteLine(y);









//float x = 5;
//float y = 6;


//float maximum(float x, float y)
//{

//    if (x < y)
//        return y;

//    else
//        return x;
//}

//Console.WriteLine("maximum je " + maximum(x,y));

//float minimum(float x, float y)
//{
//    if (x < y)
//        return x;

//    else
//        return y;
//}

//Console.WriteLine("minimum je " + minimum(x, y));

//bool rovnost(float x, float y)
//{
//    if (x==y) return true;
//    else return false;
//}

//Console.WriteLine(rovnost(x, y));   













int intcislo = 0;

Console.WriteLine("Napiš číslo");
int CisloOdUyivatele()
{
    string cislo = Console.ReadLine();
    int.TryParse(cislo, out intcislo);
    return intcislo;
}

Console.WriteLine(CisloOdUyivatele());