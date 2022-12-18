/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру это числа.
456 -> 46
782 -> 72
918 -> 98
*/
int value = new Random().Next(100, 999);
Console.WriteLine(value);

string str = value.ToString();
    int[] remoteNumber = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
    remoteNumber[i] = int.Parse(str[i].ToString());
    }
Console.Write(remoteNumber[0]);
Console.Write(remoteNumber[2]);

