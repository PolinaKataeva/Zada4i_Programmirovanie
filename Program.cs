// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии

Console.WriteLine("Введите число N");
int N = 
Convert.ToInt32(Console.ReadLine());
int index = 1;
while (N >= index)
{
    if (N == 1)
        Console.WriteLine(N);
        else
        {
            return (N-1);
            Console.WriteLine(N);
        }
}


