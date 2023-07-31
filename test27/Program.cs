// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigit = SumDigit(num);
Console.WriteLine($"Сумма цифр числа {num} -> {sumDigit}");

int SumDigit(int number)
{
    if (number < 0) number = number * (-1);
    
    int result = 0;
    while (number != 0)
    {
        result = result + number % 10;
        number /= 10;
    }
    return result;
}