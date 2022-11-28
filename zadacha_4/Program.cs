// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

Console.WriteLine("Введите число: ");
int Digit = int.Parse(Console.ReadLine());
if (Digit % 7 == 0 && Digit % 23 == 0)
{
    Console.WriteLine($"{Digit} -> кратно");
}
else
{ 
    Console.WriteLine($"{Digit} -> некратно");
}