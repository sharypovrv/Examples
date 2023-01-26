// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Clear();

Console.Write("Введите номер для недели: ");
int number = int.Parse(Console.ReadLine()!);
string day = "Понедельник";

if (number == 1) day = "Понедельник";
if (number == 2) day = "Вторник";
if (number == 3) day = "Среда";
if (number == 4) day = "Четверг";
if (number == 5) day = "Пятница";
if (number == 6) day = "Суббота";
if (number == 7) day = "Воскресенье";

if (number < 1 || number > 7) day = "Неправильный номер дня недели";

Console.WriteLine($"День недели под номером {number} - {day}.");