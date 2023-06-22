// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int m = Prompt("Введите число М");
int n = Prompt("Введите число N");
ShowSumm(m, n, 0);
int Prompt(string message) // ввод данных
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();

    }
    return val;
}
void ShowSumm(int firstnum, int secondnum, int sum)
{
    if (firstnum > secondnum)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (firstnum++);
    ShowSumm(firstnum, secondnum, sum);
}
