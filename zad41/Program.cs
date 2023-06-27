// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int NumberNumbers(int[] numbers)
{
    int number = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            number++;
        }
    }
    return number;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}
// --------------------

System.Console.WriteLine("Введите массив чисел (через запятую или пробел) :");
System.Console.WriteLine();
// int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // прием из консоли ввода в этом виде НЕ РАБОТАЕТ

int[] array = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), (item) => Convert.ToInt32(item));

PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"положительных чисел ввеедено: {NumberNumbers(array)} ");
