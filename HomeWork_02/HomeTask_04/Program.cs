/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> Да
7 -> Да
1 -> Нет
*/

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

int value = Prompt("Введите номер дня недели > ");
if(value == 6 || value == 7) 
{
    Console.WriteLine("Да");
} 
else
{
    Console.WriteLine("Нет");
}