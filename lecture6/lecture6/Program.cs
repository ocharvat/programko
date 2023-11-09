//void PrintArray(int[] cisla)
//{
//    for (int i = 0; i < cisla.Length; i++)
//    {
//        Console.WriteLine(cisla[i]);
//    }
//}

//int[] cisla = { 1, 2, 3, 4, 5};
//PrintArray(cisla);

//int[] cisla2 = cisla;
//PrintArray(cisla);
//PrintArray(cisla2);

//cisla[0] = 4545;
//PrintArray(cisla);
//PrintArray(cisla2);





int[] koeficienty  = new int[] {6, 4, 48, -4, 4, -1 };

void PrintPolynomial(int[] koeficienty)
{
   int j = koeficienty.Length - 1;
    
    for (int i = 0; i < koeficienty.Length; i++) 
    { 
      
       Console.Write(koeficienty[i] + " x^ " + j + " + ");

        j = j - 1;
      
    }
}

PrintPolynomial(koeficienty);