// . Напишите программу вычисления модуля числа.
// 2 -> 2
// -3 -> 3
// -7 -> 7
Console.WriteLine("Введите любое целое число");

string a = Console.ReadLine();
int b = int.Parse(a);
int c = Math.Abs(b);

Console.WriteLine($"Модуль числа {a} равен {c}");