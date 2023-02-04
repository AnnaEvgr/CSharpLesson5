/*Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.

[3 7 22 2 78] -> 76*/

int[] GenerateArray(int len = 10)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
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

int[] array = GenerateArray(5);
PrintArray(array);

int minimum = array[0];
int maximum = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minimum)
    {
        minimum = array[i];
    }
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }

    }
}

Console.WriteLine($"Минимальное число в массве = {minimum}");
System.Console.WriteLine($"Максимальное число в массве = {(maximum)}");

int result = maximum - minimum;
System.Console.WriteLine($"Разница между максимальным и минимальным значением = {result}");







