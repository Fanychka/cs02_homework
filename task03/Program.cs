﻿// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите номер дня недели (цифру от 1 до 7): ");
    string input1 = Console.ReadLine();
    int number = int.Parse(input1);

if (number == 1){

    
Console.WriteLine ("это НЕ ВЫХОДНОЙ день. Так как этой цифре соответствует день недели - ПОНЕДЕЛЬНИК");
}
else if (number == 2) {

    Console.WriteLine ("это НЕ ВЫХОДНОЙ день. Так как этой цифре соответствует день недели - ВТОРНИК");
}
else if (number == 3) {

    Console.WriteLine ("это НЕ ВЫХОДНОЙ день. Так как этой цифре соответствует день недели - СРЕДА");
}
else if (number == 4) {

    Console.WriteLine ("это НЕ ВЫХОДНОЙ день. Так как этой цифре соответствует день недели - ЧЕТВЕРГ");
}
else if (number == 5) {

    Console.WriteLine ("это НЕ ВЫХОДНОЙ день. Так как этой цифре соответствует день недели - ПЯТНИЦА");
}
else if (number == 6) {

    Console.WriteLine ("это ВЫХОДНОЙ день. Так как этой цифре соответствует день недели - СУББОТА");
}
else if (number == 7) {

    Console.WriteLine ("это ВЫХОДНОЙ день. Так как этой цифре соответствует день недели - ВОСКРЕСЕНЬЕ");
}
else if (number > 7) {

    Console.WriteLine ("Ты ошибся номером, Михал Палыч, пробуй еще!");
}