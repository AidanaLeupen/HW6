// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.Write("Enter the numbers in array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void Check(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Enter {i+1} element of array ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

}

int count(int[] array)
{
    int i = 0;
    int sum = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
        sum = sum + 1;
        i = i + 1;
    }
    return sum;
}

Check(n);
Console.Write($"\n Numbers bigger than zero: {count(array)}");