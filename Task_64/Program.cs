//                                 Задача 64: 
// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
//  M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//  M = 4; N = 8. -> ""4, 6, 7, 8"" // В примере пропущена пятерка )))

Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine()!);

string NumbersNatural(int M, int N) // натуральные числа в промежутке от M до N:
{
    if (M <= N)
    return $"{M}{(M != N ? "," : "")} " + NumbersNatural(M + 1, N);
    else return String.Empty;
}

Console.WriteLine($"M = {M}; N = {N}. -> {(NumbersNatural(M, N))}");

// А кавычки мне так и не удалось реализовать!)))
