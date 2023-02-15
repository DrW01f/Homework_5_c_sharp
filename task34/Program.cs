// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(99, 1000);
    }
    return res;
}

int EvenNumberedCount(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) number++;
    }
    return number;
}

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число элементов ");
    int count = int.Parse(Console.ReadLine()!);
    int[] newArray = GetArray(count);
    Console.WriteLine(String.Join(" ", newArray));
    int evenNumbers = EvenNumberedCount(newArray);
    Console.WriteLine($"Количество четных элементов в массиве равно {evenNumbers}");
}

Main();