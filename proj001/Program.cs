/*  **Задача 41**
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 // ошибка, вместо 3 -> 4    */

int[] array = new int[6];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    int a;
    Console.WriteLine("Enter a number: ");
    int.TryParse(Console.ReadLine()!, out a);
    array[i] = a;
     if (array[i]>0)
    {
        count++;
    }
}
Console.Write($"Number of numbers greater than '0' -> {count}");