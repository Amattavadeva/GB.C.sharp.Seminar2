/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.

int n = int.Parse(Console.ReadLine());
int num = (n % 100 ) / 10;

Console.WriteLine(num);
 */

int n = int.Parse(Console.ReadLine());

if (n > 5)
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}