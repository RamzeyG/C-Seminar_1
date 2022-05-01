// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine($"Введите первое число: ");

string a = Console.ReadLine().Replace('.',',');

double aa = Convert.ToDouble(a);

Console.WriteLine($"Введите первое число: ");

string b = Console.ReadLine().Replace('.',',');

double bb = Convert.ToDouble(b);

if (aa > bb){
    Console.WriteLine($"Число {a} больше числа {b}");
}
    

if (aa < bb){
    Console.WriteLine($"Число {b} больше числа {a}");
}
    


