// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Enter password:");

//string password = Console.ReadLine();


//if (password == "12345")
//{
//    Console.WriteLine("Correct password");
//}

//else
//{
//    Console.WriteLine("Wrong password");
//}





//Console.WriteLine("What is your name?");
//string name = Console.ReadLine();
//Console.WriteLine("Hello " + name);




//for (int i = 1; i < 6; i++)
//{
//    Console.WriteLine(i);
//}




//int number = 0;
//while (number < 10)
//{
//    Console.WriteLine(number);
//    number = number + 3;
//}


//int otherNumber = 0;
//do
//{
//    Console.WriteLine(otherNumber);
//    otherNumber = otherNumber + 1;

//}while (otherNumber < 10);  









Console.WriteLine("Enter a number:");
string numIterationsString  = Console.ReadLine();

int numIterations = 0;

bool success = int.TryParse(numIterationsString, out numIterations);

Console.WriteLine("success =" + success);

for (int i = 0; i < numIterations; i++)
{
    Console.WriteLine(i);
}



if (success == false)
{

do
   {
       Console.WriteLine("Enter a number:");
       Console.ReadLine();
   } while (true);

}
        
  
    
       
   

