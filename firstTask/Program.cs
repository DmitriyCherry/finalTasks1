/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/



int PrintOrderNumbers(int value)
{
    string emptyLine = "\"";
    if (value == 1) Console.Write(value + emptyLine);
    else Console.Write($"{value}, ");

    if (value == 1) return value;
    return PrintOrderNumbers(value - 1);
}

string empty = "\"";        
Console.Write("Введите число: ");
int count = int.Parse(Console.ReadLine()!);
Console.Write($"N = {count} -> {empty}");
int result = PrintOrderNumbers(count);