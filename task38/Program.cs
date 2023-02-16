// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    { //создание рандомного числа путем перемножения дроби (от 0 до 1) на 10 в степени
        res[i] = Math.Round((new Random().NextDouble() * Math.Pow(10, new Random().Next(0, 4))), 3);
    }
    return res;
}


double Difference(double[] array) //поиск разницы
{
    double max = array[0];
    double min = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    return diff;
}


void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число элементов ");
    int count = int.Parse(Console.ReadLine()!);
    double[] newArray = GetArray(count);
    Console.WriteLine(String.Join("  ", newArray));
    double result = Difference(newArray);
    Console.WriteLine($"Разница между максимальным и минимальным равна {result}");

}

Main();