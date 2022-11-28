// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// // 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());
if (FirstNumber / SecondNumber == SecondNumber || SecondNumber/FirstNumber == FirstNumber)
{
    Console.WriteLine($"{FirstNumber}, {SecondNumber} -> yes");
}
else
{
     Console.WriteLine($"{FirstNumber}, {SecondNumber} -> no");
}

