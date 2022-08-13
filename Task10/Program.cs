// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите положительное трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int RemoveSecond(int num)
{
    // int number1 = num / 100; // первая цифра
    // int number2 = num % 10; // последняя цифра
    // int nov = (num - (number1 * 100 + number2))/10;

    int nov = num / 10 % 10;
    return nov;
}
int result = RemoveSecond(number);

if (number > 100 && number < 1000)
Console.WriteLine($"{number} -> {result}");
else
    Console.WriteLine("Некорректный ввод числа");

