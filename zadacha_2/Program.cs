// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98



// int number = new Random().Next(100,999);
// Console.WriteLine(number);
// int FirstDigit = number/100;
// int ThirdDigit = number%10;
// string textFirstDigit = FirstDigit.ToString();
// string textThirdtDigit = ThirdDigit.ToString();
// string Digit =  textFirstDigit + textThirdtDigit ;

// Console.WriteLine(Digit);


//Альтернативное решение 

// int number = new Random().Next(100,999);
// Console.WriteLine(number);
// int FirstDigit = number / 100;
// int ThirdDigit = number % 10;
// int Sum = FirstDigit * 10 + ThirdDigit;
// Console.WriteLine(Sum);

// Решение с одной переменной 

int number = new Random().Next(100,999);
Console.WriteLine(number);
int result = (number / 100) * 10 + (number % 10);
Console.WriteLine(number + "->" + result);