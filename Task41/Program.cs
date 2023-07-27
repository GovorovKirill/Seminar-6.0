// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Ведите будущее количество чисел");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine("Ведите число и нажмите Enter");
    array[i] = int.Parse(Console.ReadLine());
}

Console.Write("Ваши числа: ");

Console.Write("[");
for (int i = 0; i < size; i++)
{
    if (i < size - 1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
}
Console.Write("], ");

int quantityPositiveNum = QuantityPositiveNum(array);
Console.WriteLine($"из них больше нуля -> {quantityPositiveNum}");

Console.ReadLine();


int QuantityPositiveNum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}