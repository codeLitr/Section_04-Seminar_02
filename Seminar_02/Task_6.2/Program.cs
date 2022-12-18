/*Напишите программу, которая на вход принимает пять чисел
и выводит сумму и среднее арифметическое этих чисел.
2, 5, 6, 8, 1 - > сумм 22, среднее 4.4

ВАРИАНТ РЕШЕНИЯ С ИСПОЛЬЗОВАНИЕМ МАССИВОВ + ФУНКЦИЯ
*/
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
// int number1 = Prompt("Введите число 1: ");
// int number2 = Prompt("Введите число 2: ");
// int number3 = Prompt("Введите число 3: ");
// int number4 = Prompt("Введите число 4: ");
// int number5 = Prompt("Введите число 5: ");
// int summ = number1 + number2 + number3 + number4 + number5;
// double average = summ / 5;
// Console.WriteLine($"{number1}, {number2}, {number3}, {number4}, {number5} -> сумма {summ}, среднее {average}");

int[] numbers = new int[5]; // Объявление массива, number это его название (может быть любым), 5 это размер массива
for (int i = 0; i < numbers.Length; i++) // Цикл - пока i меньше длины массива, прибавляем к i 1
{
    numbers[i] = Prompt($"Введите число {i + 1}: "); // Заменят вариант (выше) с объявлением всех переменных, вместо этого будет перебираться массив и какой длинны массив, столько и будет запрошено чисел
}
int summ = Summ(numbers);
double average;
average = summ / numbers.Length;
Console.WriteLine(summ);
Console.WriteLine(average);

int Summ(int[] numbers) //Функция. Название функции пишется с большой буквы
{
    int summ = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        summ += numbers[i];
    }
    return summ;
}