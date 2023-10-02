// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = M; i <= N; i++)
{
    sum += i;
}

Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} равна {2}", M, N, sum);