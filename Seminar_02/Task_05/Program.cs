/*
Напишите программу, которая выводит случайное число из отрезка
[10, 9999] и показывает наибольшую цифру числа.
812 -> 8
1213 -> 3
845 -> 8
*/
int number1 = new Random().Next(10, 9999);
Console.WriteLine(number1);
int max = 0;
while (number1 > 0)
{
    int temp = number1 % 10;
    if (max < number1 % 10)
        max = temp;
        number1 = number1 / 10;
}
Console.WriteLine(max);