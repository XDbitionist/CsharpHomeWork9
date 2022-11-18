/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
void PrintSum(int m, int n, int sum)
 {
    sum = sum + n;
    if (n <= m)
    {
        Console.Write(sum);
        return;
    }
    PrintSum(m, n-1, sum);
}
Console.WriteLine("Задайте промежуток M : N: ");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
Console.Write("Сумма натуральных элементов в промежутке M : N: ");
PrintSum(m, n, temp = 0); 