/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/


int[] GettingArray(int length)
{
    int[] array = new int[length];
    Random rd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rd.Next(0, 99);
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


int SumOfOddElements(int[] position)
{
    int summa = 0;
    int length = position.Length;
    for (int index = 1; index < length; index = index + 2)
    {
        summa = summa + position[index];
    }
    return summa;
}

int[] myArray = GettingArray(5);

printArray(myArray);

int summa = SumOfOddElements(myArray);

Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, равна {summa}");