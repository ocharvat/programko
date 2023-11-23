
//int[] array = new int[] {4, 18, 12, 6, -4, 5};

//int FindMaxIndex(int[] array)
//{
//    int max = array[0];
//    int maxI = 0;

//    for (int i = 0; i < array.Length; i++)
//    {
//      max = Math.Max(max,array[i]);
//      maxI = i;
//    }
     
//    return maxI;
//}

//int maximum = FindMaxIndex(array);
//Console.WriteLine(maximum);



//int FindMaxIndex(int[] array)
//{
//    int max = array[0];

//    for (int i = 0; i < array.Length; i++)
//        max = i + 1;

//    return max;
//}

//int maximumI = FindMaxIndex(array);
//Console.WriteLine(maximumI);










void GreetUser(string name = "user")
{
    Console.WriteLine("Hello " +  name + "!");
}

GreetUser("Ondra");
GreetUser();