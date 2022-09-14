// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int DataEntry(string message)                               //Метод ввода данных
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[] array)                              //Метод заполнения массива
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

double DifferenceBetweenMaxAndMin(double[] array)           //Метод вычисления разницы между
{                                                           //максимальным и минимальным элементами массива
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    return max-min;
}

int size = DataEntry("Введите размер массива -> ");
double[] numbers = new double[size];
FillArray(numbers);
System.Console.WriteLine("[{0}]", string.Join(", ", numbers));
System.Console.WriteLine();
System.Console.WriteLine($"Разность между максимальным и минимальным значением массива равна {DifferenceBetweenMaxAndMin(numbers)}.");