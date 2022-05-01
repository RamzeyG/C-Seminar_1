// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите любое целое число: ");

string a = Console.ReadLine().Replace('.',',');

double b = Convert.ToDouble(a);

int count = 2;

Console.WriteLine($"Список четных чисел в промежутке от 1 до {b}: ");

while(count <= b){
    Console.Write($"{count}, ");
    count = count + 2;
}


