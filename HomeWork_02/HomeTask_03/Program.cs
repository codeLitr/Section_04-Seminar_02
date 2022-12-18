/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> Третьей цифры нет
32679 -> 6
*/


// ВАРИАНТ РЕШЕНИЯ 1:

// int Prompt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine() ?? "0";
//     int value = int.Parse(strValue);
//     return value;
// }
// int temp = Prompt("Введите число > ");
// if (temp < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     if (temp < 1000 && temp > 99)
//     {
//         int result = temp % 10;
//         Console.WriteLine(result);
//     }
//     else
//     {
//         string str = temp.ToString();
//         int[] thirdNumber = new int[str.Length];
//         for (int i = 0; i < str.Length; i++)
//         {
//             thirdNumber[i] = int.Parse(str[i].ToString());
//         }
//         Console.WriteLine(thirdNumber[2]);
//     }
// }


// ВАРИАНТ РЕШЕНИЯ 2:

// int Prompt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine() ?? "0";
//     int value = int.Parse(strValue);
//     return value;
// }
// int temp = Prompt("Введите число > ");
// if (temp < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// if(temp > 100)
// {
// string str = temp.ToString();
//     int[] thirdNumber = new int[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         thirdNumber[i] = int.Parse(str[i].ToString());
//     }
//     Console.WriteLine(thirdNumber[2]);
// }