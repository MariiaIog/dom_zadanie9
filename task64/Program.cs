/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void NumberCounter(int N)
{
    if (N < 0)
    {
        Console.WriteLine("ОШИБКА! Введите число БОЛЬШЕ 0!");
        return;
    }
    if (N == 0) return;
    Console.WriteLine($"{N} ");
    NumberCounter(N - 1);

}
NumberCounter(N);