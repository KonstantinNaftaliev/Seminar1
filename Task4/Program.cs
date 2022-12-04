// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456->6 782->2 918->8

Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

int result = n % 10;
Console.WriteLine(result);