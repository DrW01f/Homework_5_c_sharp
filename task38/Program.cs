// Задача 38: Задайте массив вещественных чисел. Найдите разницу между \
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76






double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
        // res[i] = Math.Round(res[i],3);
    }
    return res;
}



void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число элементов ");
    int count = int.Parse(Console.ReadLine()!);
    double[] newArray = GetArray(count);
    Console.WriteLine(String.Join(" ", newArray));

}

Main();