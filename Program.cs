using System;

// 1. Ədədin sade və ya murekkeb olduğunu tapan proqram

//Console.WriteLine("eded daxil et");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num < 2)
//{
//    Console.WriteLine("ne sade deyil ne murekkeb");
//}
//else if (num==2)
//{
//    Console.WriteLine("sadedir"); 
//}


//for (int i = 2; i < num; i++)
//{

//    if (num % i == 0)
//    {
//        Console.WriteLine("murekkeb ededdir");
//        return;
//    }

//}
//Console.WriteLine("sade ededdir");




Console.WriteLine("Ədədi daxil et:");
int num = Convert.ToInt32(Console.ReadLine());
int power = 1;

if (num <= 0)
{
    Console.WriteLine("bu ededin quvveti ola bilmez");
}

else
{
    while (num > power)
    {
        power *= 2;
    }
    if (num == power)
    {
        Console.WriteLine("Bu eded 2 nin quvvetidir");
    }
    else
    {
        Console.WriteLine("Bu eded 2 nin quvveti deyil");
    }
}


















//3. Ədədin faktorialını hesablayan proqram

//Console.WriteLine("eded daxil et");
//int num1 = Convert.ToInt32(Console.ReadLine());

//int faktorial = 1;

//for (int i = 1; i <= num1; i++)
//{
//    faktorial *= i;
//}
//Console.WriteLine(faktorial);