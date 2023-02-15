// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100, 101);
    }
    return res;
}










void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число элементов ");
    int count = int.Parse(Console.ReadLine()!);
    int[] newArray = GetArray(count);

}

Main();