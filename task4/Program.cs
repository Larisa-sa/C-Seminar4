// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
//[1,0,1,1,0,1,0,0]
Console.Clear();
int[] array = new int[8]; // создаем массив, 8 элементоа. 
// далее ссылаемся на 2 процедуры:
PrintArray(array);
FillArray(array); // заполнение массива
PrintArray(array); // печать массива
void FillArray(int[] collection) // 1 метод - заполнение массива. На вход подается массив. Метод невозвращаемого типа. Но он все равно обрабатывает наш массив. Мы туда положили аргумент (int[collection]), который туда поступит и мы его обработаем. collection = array
{
    int length = collection.Length; // измеряется длина массива
    int index = 0; // индекс устанавливаем на ноль
    while (index < length) //начинаем цикл
    {
        collection[index] = new Random().Next(0,2); //в каждый элемент массива кладется случайное число от 0 до 1(2 не входит)
        index++; // таким образом весь массив целиком заполняется
    }
}
void PrintArray(int[]coll) // 2 метод - печать массива(вывод). На вход метода подается массив произвольного размера.
{
    int count = coll.Length; //
    int position = 0; //
    Console.Write("["); //
    while (position < count) //
    {
        Console.Write($"{(position == 0 ? coll[position] : "," + coll[position])}"); //
        position++;
    };
    Console.WriteLine("]\r\n"); //
}