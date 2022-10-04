// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел:");
string numbers = Console.ReadLine();
string[] newNumbers = new string[numbers.Length];
int m = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
    if (numbers[i] == ' ')
    {
        m++;
    }
    else
    {
        newNumbers[m] = newNumbers[m] + $"{numbers[i]}";
    }
}
m++;
int[] resultNumbers = new int[m];
PrintArray(resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < m; i++)
{
    if (resultNumbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine("Количество чисел больше 0: " + sum);

void PrintArray(int[] array, string[] string1)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(string1[i]);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}