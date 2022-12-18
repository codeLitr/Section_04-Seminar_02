/*
Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа 
предварительно введенному числу, при кратности - цикл прерывается.
Введенное число 2
13 -> Нет
15 -> Нет
12 -> Да
*/
int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int randNumb1 = new Random().Next(0, 50);
// Console.WriteLine($"Первое число: {randNumb1}");
int randNumb2 = new Random().Next(0, 50);
// Console.WriteLine($"Второе число: {randNumb2}");
int randNumb3 = new Random().Next(0, 50);
// Console.WriteLine($"Третье число: {randNumb3}");

Console.WriteLine();
int value = Prompt("Введите число для проверки на кратность > ");

Console.WriteLine();
Console.WriteLine($"Введенное число: {value}");

int numb1 = randNumb1 % value;
int numb2 = randNumb2 % value;
int numb3 = randNumb3 % value;

if (numb1 != 0 ) 
{
    Console.WriteLine ($"{randNumb1} -> Первое число не кратно введенному");
}
else
{
    Console.WriteLine ($"{randNumb1} -> Первое число кратно введенному");
}

if (numb2 != 0) 
{
    Console.WriteLine ($"{randNumb2} -> Второе число не кратно введенному");        
}
else
{
    Console.WriteLine ($"{randNumb2} -> Второе число кратно введенному");        
}

if (numb3 != 0) 
{
    Console.WriteLine ($"{randNumb3} -> Третье число не кратно введенному");    
}
else
{
    Console.WriteLine ($"{randNumb3} -> Третье число кратно введенному");  
}