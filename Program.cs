using System;
using System.ComponentModel.Design;

// 1. Ədədin sade və ya murekkeb olduğunu tapan proqram

//Console.WriteLine("eded daxil et");
//int num = Convert.ToInt32(Console.ReadLine());
//int divisor = 0;

//if (num < 2)
//{
//    Console.WriteLine("ne sade deyil ne murekkeb");
//}
//else if (num == 2)
//{
//    Console.WriteLine("Bu eded sade ededdir");
//}

//for (int i = 2; i < num; i++)
//{

//    if (num % i == 0)
//    {
//        divisor++;
//    }

//}
//if (divisor > 0)
//{
//    Console.WriteLine("Bu eded murekkeb ededdir");
//}
//else
//{
//    Console.WriteLine("Bu eded sade ededdir");
//}





//2.Ədədin 2 - nin quvvəti olub olmadığını tapan proqram

Console.WriteLine("Ededi daxil et:");
int num = Convert.ToInt32(Console.ReadLine());
int power = 1;

if (num <=0)
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