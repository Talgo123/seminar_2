// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// int FirstNumber = new Random().Next(1,99);
// int SecondNumber = new Random().Next(1,9);
// Console.WriteLine($"Первое число {FirstNumber}. Второе число {SecondNumber}");

Console.WriteLine("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());

int quotient = FirstNumber % SecondNumber;
if (quotient == 0)
{
    Console.WriteLine($"{FirstNumber}, {SecondNumber} -> кратно");

}
else
{
    Console.WriteLine($"{FirstNumber}, {SecondNumber} ->  не кратно, остаток равняется {quotient}");
}
