//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
/*
int size = WorkWithUser("Введите размер массива: ");
int minValue=WorkWithUser("Введите минимальное значение диапазона: ");
int maxValue=WorkWithUser("Введите максимальное значение диапазона: ");
int[] array=GetArray(size,minValue,maxValue);
PrintArray(array);

int WorkWithUser(String message)
{
    Console.Write(message);
    int number=int.Parse(Console.ReadLine());
    return number;
}
int[] GetArray(int Length, int min, int max)
{
    int[] result=new int[Length];
    Random rand=new Random();
    for(int i=0; i<result.Length;i++)
    {
        result[i]=rand.Next(min,max+1);
    }
    return result;
}
void PrintArray(int[]arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        Console.Write(arr[i]+ " ");
    }
}
int kon=0;    
for(int i=0; i<array.Length;i++)
    {
        if(array[i]%2==0)
        {
            kon++;
        }
    }
Console.Write(" ");
Console.Write($"{kon}");

Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

int size = WorkWithUser("Введите размер массива: ");
int minValue=WorkWithUser("Введите минимальное значение диапазона: ");
int maxValue=WorkWithUser("Введите максимальное значение диапазона: ");
int[] array=GetArray(size,minValue,maxValue);
PrintArray(array);

int WorkWithUser(String message)
{
    Console.Write(message);
    int number=int.Parse(Console.ReadLine());
    return number;
}
int[] GetArray(int Length, int min, int max)
{
    int[] result=new int[Length];
    Random rand=new Random();
    for(int i=0; i<result.Length;i++)
    {
        result[i]=rand.Next(min,max+1);
    }
    return result;
}
void PrintArray(int[]arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        Console.Write(arr[i]+ " ");
    }
}
int kon=0;    
for(int i=0; i<array.Length;i++)
    {
        if(array[i]%2==1)
        {
            kon=kon+array[i];
        }
    }
Console.Write(" ");
Console.Write($"{kon}");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
    randomArray[i] = rand.NextDouble();
    Console.Write($"{randomArray[i]:F2} ");
    }

}
double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

mas(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");

