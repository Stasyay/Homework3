// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

while (x < 9999 || x > 99999)
{
    Console.Write("Неправильно, попробуйте еще раз:  ");
    x = Convert.ToInt32(Console.ReadLine());
}

int FirstNumber = x / 10000  % 10;
int SecondNumber = x / 1000  % 10;
int FourthNumber = x / 10  % 10;
int FifthNumber = x % 10;

if (FirstNumber == FifthNumber && SecondNumber == FourthNumber)
    Console.Write("Это число является палиндромом");
else
    Console.Write("Это число не является палиндромом");
