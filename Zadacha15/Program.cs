//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine());
if((a < 1) || (a>7))
{
    Console.WriteLine("Нет такого дня недели");
    return;
}
if(a > 5)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это рабочий день");
}
