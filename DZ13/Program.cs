/*Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6      */

Console.WriteLine("Введите число: ");
Random rand = new Random();
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  Console.WriteLine("третья цифра " + numberText[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}
