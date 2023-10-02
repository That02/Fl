// See https://aka.ms/new-console-template for more information
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Результат: ");
PrintNumbers(n);
Console.ReadLine();

void PrintNumbers(int n)
{
if (n <= 0)
return;

Console.Write(n + ", ");
PrintNumbers(n - 1);
}
