// Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение
// 1 -> 1
// 2 -> 0.5
// 0.25 -> 4

Console.WriteLine("Введите любое число: ");

string a = Console.ReadLine().Replace('.', ','); // при вводе числа формата 0.25 выводит ошибку

Console.WriteLine(a);

double b = Convert.ToDouble(a);
Console.WriteLine(b);

double c = 1/b;

Console.WriteLine($"Введено число: {a}.\nПреобразовано в: {c}");


