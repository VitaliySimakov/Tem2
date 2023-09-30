Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

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
int ant=0;
int kon=0;    
for(int i=0; i<array.Length;i++)
    {
        if(array[i]>0) kon++;
        else ant++;
    }
Console.Write(" ");
Console.Write($"{kon}");



