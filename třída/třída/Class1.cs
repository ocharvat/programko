

//public class Person
//{
//	public string Name;
//	public string BirthDate;
//	public int RodneCislo;
//	public string Address;
//	public int NumFingers;
//	public string Sex;
//	public float Height;
//}


using System.Reflection;

class Auto
{
    public string Znacka;
    public string Model;
    public int RokVyroby;
    public string Barva;
    public string Motor;
    public double Objem;
    public int Vykon;

    public void PrintAuto()
    {
        Console.WriteLine(Znacka);
        Console.WriteLine(Model);
        Console.WriteLine(RokVyroby);
        Console.WriteLine(Barva);
        Console.WriteLine(Motor);
        Console.WriteLine(Objem + " l");
        Console.WriteLine(Vykon + " hp");
    }
}