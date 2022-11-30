/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.*/

double[] GettingArray(int length)
{
    double[] array = new double[length];
    Random rd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rd.Next(0, 99);
    }
    return array;
}

void printArray(double[] array)
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

double MinElement(double[] array)
{
    int length = array.Length;
    double min = array[0];
    for (int index = 0; index < length; index++)
    {
        if (array[index] < min)
        {
            min = array[index];
        }
    }
    return min;
}

double MaxElement(double[] array)
{
    int length = array.Length;
    double max = array[0];
    for (int index = 0; index < length; index++)
    {
        if (array[index] > array[0])
        {
            max = array[index];
        }
    }
    return max;
}

double[] myArray = GettingArray(9);
printArray(myArray);
double differentMaxMin = MaxElement(myArray) - MinElement(myArray);
Console.WriteLine($"Разница между максимальным и минимальным значением массива равна {MaxElement(myArray)} - {MinElement(myArray)} = {differentMaxMin}");