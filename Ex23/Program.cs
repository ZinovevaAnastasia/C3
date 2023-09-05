//Задача 23: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//кубов чисел от 1 до N.

void Tablesquer ( int num)
{
int index = 1;
 while (index<=num)
 {
    Console.WriteLine($"Куб {index} -> {index*index*index}");
    index++;
 }   
}

Console.WriteLine("Введите целое число");
Console.Write("N = ");
int numb = Convert.ToInt32(Console.ReadLine());

Tablesquer(numb);
