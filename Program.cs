//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


//Console.WriteLine("введите первое число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("введите Второе число: ");
//int number2 = int.Parse(Console.ReadLine());
//if (number1 > number2)
//Console.WriteLine(number1);
//else
//    Console.WriteLine(number2);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//Console.WriteLine("введите число: ");
//int number1 = int.Parse(Console.ReadLine());
//if (number1 %2 ==0) 
//System.Console.WriteLine("Да");
//    else 
//    System.Console.WriteLine("Нет");

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int num = int.Parse(Console.ReadLine());
int i = 2;
if (i>num) Console.WriteLine("Четных чисел от 1 до введенного числа нет");
while (i<=num)
{
   if ((i%2==0 && i==num) || (i%2==0 && i+1==num))
    {    
        Console.Write(i);
    }
    else if (i % 2== 0)
    {    
        Console.Write(i+ ",");
    }
    i++;
}
