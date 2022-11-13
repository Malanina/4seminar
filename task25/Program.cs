// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  натуральное число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = 1;

if (numberB > 0)
{
    for (int i = 0; i < numberB; i++)
    {
        result = result * numberA;
    }
    Console.WriteLine("А в степени В равно: " + result);
}
else
    Console.WriteLine("Введите натуральное число В, т.е. число  должно быть больше нуля");

