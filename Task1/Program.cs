// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int number = Prompt("Введите число");
int count = 1;
ShowNumbers(number, count);

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
void ShowNumbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        ShowNumbers(n, count + 1);
        Console.Write(count + " ");
    }
}
