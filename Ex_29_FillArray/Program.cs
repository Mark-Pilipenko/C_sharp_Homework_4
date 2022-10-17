// Задача 29: 
// Напишите программу, которая задаёт массив произвольной длины, 
// заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или 
// попросить пользователя ввести в консоли.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] rand = FillArray(len, min, max);
PrintArray(rand);

int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        if (i == n - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}