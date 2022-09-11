﻿// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int numberA = new Random().Next(100, 1000);

Console.WriteLine($"{numberA} - Сгенерированное случайное трехзначное число");

// int digit2 = ((numberA /10) % 10);  В строке 8 не нужны ни внешние, ни даже внутренние скобки. У операции % нет приоритета перед

int digit2 = numberA / 10 % 10;

Console.WriteLine ($"{digit2} - Вторая цифра этого числа");
