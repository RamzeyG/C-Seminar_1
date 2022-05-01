// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine($"Введите первое число: ");

string a = Console.ReadLine().Replace('.',',');

double aa = Convert.ToDouble(a);

Console.WriteLine($"Введите второе число: ");

string b = Console.ReadLine().Replace('.',',');

double bb = Convert.ToDouble(b);

Console.WriteLine($"Введите третье число: ");

string c = Console.ReadLine().Replace('.',',');

double cc = Convert.ToDouble(c);

Console.WriteLine($"Из чисел {a}, {b}, {c}");

if (aa > bb & aa > cc){
    Console.WriteLine($"Число {a} самое большое число");
}
if (bb > aa & bb > cc){
    Console.WriteLine($"Число {b} самое большое число");
}

if (cc > bb & cc > aa){
    Console.WriteLine($"Число {c} самое большое число");
}