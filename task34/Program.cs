/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */


int[] GettingArray(int length)
{
    int[] array = new int[length];
    Random rd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rd.Next(100, 999);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}


int NumberOfEvenElement(int[] position)
{
    int count = 0;
    int length = position.Length;
    for (int index = 0; index < length; index++)
    {
        if (position[index] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] myArray = GettingArray(5);

printArray(myArray);

int count = NumberOfEvenElement(myArray);

Console.WriteLine($"Количество четных элементов в массиве равно {count}");

