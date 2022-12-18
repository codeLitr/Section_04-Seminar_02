/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если число второе не кратно первому, то программа выводит остаток от деления, если кратно, то выводит слово "кратно".
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
} 
int number1 = Prompt("Введите первое число: ");
int number2 = Prompt("Введите второе число: ");
int value = number2 % number1;
if (value != 0) //!= 0 - не равно =
{
       Console.WriteLine ($"{number2}, {number1} -> не кратно, остаток {value}");    
}
else
{
    Console.WriteLine($"{number2}, {number1} -> кратно");
}