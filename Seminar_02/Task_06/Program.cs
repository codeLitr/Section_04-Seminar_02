/*Напишите программу, которая на вход принимает пять чисел
и выводит сумму и среднее арифметическое этих чисел.
2, 5, 6, 8, 1 - > сумм 22, среднее 4.4
*/
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
} 
int number1 = Prompt("Введите число 1: ");
int number2 = Prompt("Введите число 2: ");
int number3 = Prompt("Введите число 3: ");
int number4 = Prompt("Введите число 4: ");
int number5 = Prompt("Введите число 5: ");
int summ = number1 + number2 + number3 + number4 + number5;
double average = summ / 5;
Console.WriteLine($"{number1}, {number2}, {number3}, {number4}, {number5} -> сумма {summ}, среднее {average}");
