﻿//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine());
if(a < 100){
    Console.WriteLine("Число меньше 100");
}else{
    while(a > 1000){
        a /=10;
    }
    Console.WriteLine(a % 10);
}
