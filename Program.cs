// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] array  = new int[4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
}

void PrintArray(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

int count = 0;
void Find(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] %2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

PrintArray(array);
Console.WriteLine();
Find(array);