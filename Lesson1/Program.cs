// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// Например: 4->16
// 3->19 7->49

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

int result = number * number;

Console.WriteLine(result);