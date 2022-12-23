//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
num = num/10%10;
Console.WriteLine($"Вторая цифра числа {num}");