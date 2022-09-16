//                                     Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine()!);
Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine()!);

int SumElements(int M, int N) // сумма натуральных элементов в промежутке от M до N.
{
    if (M == N) return M; 
    else if (M < N) return N + SumElements(M, N - 1);
    else if (M > N)return N + SumElements(M, N + 1);
    else return 0;
}

Console.WriteLine($"M = {M}; N = {N} -> {(SumElements(M, N))}");
