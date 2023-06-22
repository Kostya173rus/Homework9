// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// int m = Prompt("Введите число М");

int m = Prompt("Введите число М");
int n = Prompt("Введите число N");
ShowAkkermanFunction(m,n);

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

void ShowAkkermanFunction(int firstnumm, int secondnum)
{
 Console.Write($"A ({firstnumm},{secondnum}) = {MainFunction(firstnumm, secondnum)}"); 
}

int MainFunction(int firstnumm, int secondnum)
{
    if (firstnumm == 0)
    {
        return secondnum + 1;
    }
    else if (secondnum == 0 && firstnumm > 0)
    {
        return MainFunction(firstnumm - 1, 1);
    }
    else
    {
        return (MainFunction(firstnumm- 1, MainFunction(firstnumm, secondnum - 1)));
    }
}