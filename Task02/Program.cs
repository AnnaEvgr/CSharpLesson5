/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);   //число в массиве
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();

}

int SumSign(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i % 2) == 0) // берем индекс
          {
            sum = sum + array[i];
        }

    }
    return sum;
}

int[] array = GenerateArray(4);
PrintArray(array);

System.Console.WriteLine($"Сумма чисел на нечётных позициях = {SumSign(array)}");

