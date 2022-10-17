// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int B = Convert.ToInt32(Console.ReadLine());

double AB = Power(A, B);
Console.WriteLine($"{A} в степени {B} равно {AB}");

double Power(double num, int deg)
{
    double result = 1;
    if (deg != 0)
    {
        for (int i = 1; i <= Math.Abs(deg); i++)
        {
            result = result * num;
        }
        if (deg < 0) result = 1 / result;
    }
    return result;
}