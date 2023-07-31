// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введте первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введте второе натуральное число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (secondNum < 1)
{
    Console.WriteLine("Второе число не натуральное");
    return;
}

int pow = Pow(firstNum, secondNum);
Console.WriteLine($"{firstNum} в степени {secondNum} = {pow}");
int Pow(int first, int second)
{
    int powFirst = 1;
    int i = 0;
    while (i < second)
    {
        checked
        {
            powFirst = powFirst * first;
            i++;
        }
    }
    return powFirst;
}
