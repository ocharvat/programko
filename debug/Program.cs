

//Console.WriteLine("Jaky soubor?");
//string x = Console.ReadLine();




//try
//{
//    string[] cesta = File.ReadAllLines(x);
//    StreamReader reader = new StreamReader(cesta[0]);
//    Console.WriteLine(cesta[0]);
//}


//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}




static string GetPathFromUser()
{
    Console.WriteLine("Enter path");
    string path = Console.ReadLine();
    return path;
}

static void PrintErrorMessage()
{
    Console.WriteLine("File does not exist");
}

static string GetFileContents(string path)
{
    return File.ReadAllText(path);
}

static void PrintFileContents(string path)
{
    try
    {
        string contents = GetFileContents(path);
        Console.WriteLine(contents);
    }
    catch (Exception e)
    {
        PrintErrorMessage();
    }
}

static void UserReadFile()
{
    string path = GetPathFromUser();

    PrintFileContents(path);
}


UserReadFile();