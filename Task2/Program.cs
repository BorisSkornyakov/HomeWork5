// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array, int size)                       //Метод заполнения массива
{
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

int DataEntry(string message)                               //Метод ввода данных
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfOddElements(int[] array)                            //Метод подсчета суммы нечетных элементов
{
    int result = 0;
    for(int i = 0; i < array.Length; i +=2)
    {
        result += array[i];
    }
    return result;
}

int size = DataEntry("Введите размер массива -> ");             //Вводим размер массива
int[] numbers = new int[size];
FillArray(numbers, size);                                       //Заполняем массив
System.Console.Write("[{0}]", string.Join(", ", numbers));      // выводим в комсоль элементы массива
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечетных элементов массива равна {SumOfOddElements(numbers)}");    // выводим сумму нечетных элементов массива
