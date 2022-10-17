Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {A} равна {DigSum(A)}");

int DigSum(int num)
{
    num = Math.Abs(num);
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
