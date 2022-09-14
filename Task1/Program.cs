// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)                                               //метод заполнения массива
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int CountMultipli(int[] array, int x)                                     //Метод подсчета количства чисел в массиве кратных заданному числу
{
    int count = 0;
    for(int i = 0; i <array.Length; i++)
    {
        if(array[i] % x == 0)
        {
            count += 1;
        }
    }
    return count;
}

int DataEntry(string message)                                             //Метод ввода данных
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] numbers = new int[10];                                              //Задаем массив
FillArray(numbers);                                                       //Заполняем массив
System.Console.Write("[{0}]", string.Join(", ", numbers));                //Печатаем полученный массив
System.Console.WriteLine();
                            //Вводим число на кратность которому будем проверять числа массива
                            
int multiplicity = DataEntry("Введите число на кратность которому нужно проверить массив -> "); 
System.Console.WriteLine($"В массиве {CountMultipli(numbers, multiplicity)} чисел кратных {multiplicity}");