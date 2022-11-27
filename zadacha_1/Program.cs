// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int Number = new Random(). Next (10, 99);
Console.WriteLine(Number);

int NumberA = Number / 10;
int NumberB = Number % 10;
int max = NumberB;

if (NumberA > NumberB)  max = NumberA;

Console.WriteLine($"Максимальная цифра из числа {Number} равна {max} ");
