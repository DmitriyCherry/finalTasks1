/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int SumInterval (int beginInterval, int endInterval)
{
    int sum = 0;
    sum += endInterval;
    if (endInterval == beginInterval) return endInterval;
    else
    {
        return sum += SumInterval(beginInterval, endInterval - 1);      
    }
}

/*int SumInterval(int beginInterval, int endInterval)
{
    int sum = 0;
    while (beginInterval <= endInterval)
    {
        sum += beginInterval;
        beginInterval++;
    }
    return sum;
}*/

void main()
{
    Console.Write("Введите начало интервала: ");
    int countM = int.Parse(Console.ReadLine()!);
    Console.Write("Введите конец интервала: ");
    int countN = int.Parse(Console.ReadLine()!); ;
    int result = SumInterval(countM, countN);
    Console.Write($"M = {countM} ; N = {countN} -> {result}");
}

main();