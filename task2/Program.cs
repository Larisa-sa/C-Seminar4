// Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear(); 
Console.WriteLine("Введите число: "); // вводим по условию число
int number1 = int.Parse(Console.ReadLine()); // переводим в int
int number = Math.Abs(number1); // вводим еще одну переменную и берем модуль (полько положит значение)

int GetCount(int number) // метод
{
    int count = 0; //
    while (number > 10) // пока остаток больше 10, делим его на 10
{
   number = number / 10; //
   count ++; // счетчик
}
return count+1; // когда остаток остается меньше 10, мы добавляем еще 1, чтобы последнюю цифру взять
}

Console.WriteLine($"{number1} -> {GetCount(number)}");