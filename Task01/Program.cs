/*Задача 1: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(99, 1000);
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
int[] array = GenerateArray(4);
PrintArray(array);

int EvenNumber(int[] array)
{
    int evencount = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        evencount++;

    }

    return evencount;
}
System.Console.WriteLine($"Количество четных чисел в массиве > {EvenNumber(array)}");



