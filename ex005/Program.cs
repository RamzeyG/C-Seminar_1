﻿// 3. Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите любое число");

string a = Console.ReadLine().Replace('.',',');

double aa = Convert.ToDouble(a);

if (aa%2 == 0){
    Console.WriteLine($"Число {a} является четным");
}

else{
    Console.WriteLine($"Число {a} является нечетным");
}
