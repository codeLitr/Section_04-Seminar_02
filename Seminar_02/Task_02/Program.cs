/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/

int value = new Random().Next(10, 100);
Console.WriteLine(value);

int firstNumber = value / 10;
int secondNumber = value % 10;

if(firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}