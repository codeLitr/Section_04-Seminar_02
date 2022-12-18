/*
Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int a = Prompt("Введите трехзначное число > ");
if (a < 1000 && a > 99)
{
    int result = a % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}