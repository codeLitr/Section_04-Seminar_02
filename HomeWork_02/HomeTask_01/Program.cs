/*
Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите трехзначное число > ");
if (value < 1000 && value > 99)
{
    string str = value.ToString();
    int[] secondNumber = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
    secondNumber[i] = int.Parse(str[i].ToString());
    }
Console.WriteLine(secondNumber[1]);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}