﻿// See https://aka.ms/new-console-template for more information
using AddTask;

Console.WriteLine("Hello, Teacher!");

int a = 12;
int b = 3;

Console.WriteLine($"Сумма {a} и {b} равна {Calculator.Add(a,b)}");
Console.WriteLine($"Разница {a} и {b} равна {Calculator.Min(a, b)}");
Console.WriteLine($"Произведение {a} и {b} равно {Calculator.Multi(a, b)}");
Console.WriteLine($"Деление {a} на {b} равно {Calculator.Div(a, b)}");
Console.WriteLine($"Остаток от деления {a} на {b} равен {Calculator.Rem(a, b)}");
