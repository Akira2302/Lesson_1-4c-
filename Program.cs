// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int i = 2;
Console.WriteLine("Введите число:");
string str1 = Console.ReadLine();
int N = Convert.ToInt32(str1);
while (i <= N)
{
if (i % 2 != 1)
{
Console.Write(i + ", ");
}
i += 2;
}