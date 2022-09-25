// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear(); 
Console.Write("Введите число: "); // вводим по условию число
int number = int.Parse(Console.ReadLine()); // переводим в int

int GetSum(int number) // метод
{
    int sum = 0;
    while (number > 0)
    {
        int num = number % 10;
        number = number / 10;
        sum = sum + num;
    }
return sum;
}
Console.WriteLine($"{number} -> {GetSum(number)}");