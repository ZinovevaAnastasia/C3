// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string Palindrom (int num)
{
  if (num <= 9999 || num >= 100000) return "не пятизначное";
    int a =(num - num % 10000) / 10000;
    int b = (num % 10000 - num % 1000) / 1000;
    int c = (num % 100 - num % 10) / 10;
    int d = num % 10;
if(a == d && b == c) return "палиндром";
if (a != d && b != c) return "не палиндром";
if (b == 0 && c == 0 && d == 0) return "не палиндром";
return null;
}

Console.Write("Введите пятизначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());

string p = Palindrom(numb);
Console.WriteLine($"Число <{numb}> {p}");
