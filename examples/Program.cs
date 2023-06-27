// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
// int[] FillArray(int size, int leftRange, int rightRange)
// {
//     int[] tempArray = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < tempArray.Length; i++)
//     {
//         tempArray[i] = rand.Next(leftRange, rightRange + 1);
//     }

//     return tempArray;
// }
// void PrintArray(int[] arrayForPrint)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
// }

// bool CheckTriangle(int[] array)
// {
//     if ((array[0] < array[1] + array[2]) && (array[1] < array[0] + array[2]) && (array[2] < array[1] + array[0]))
//     {
//         return true;
//     }
//     return false;
// }
// //.........................
// int[] array = FillArray(3, 15, 20);

// PrintArray(array);
// //bool check = CheckTriangle(array);

// if (CheckTriangle(array))
// {
//     System.Console.WriteLine("Такой треугольник существует!");
// }
// else
// {
//     System.Console.WriteLine("Такой треугольник не существует!");

// }

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3  -> 11
// 2  -> 10

// int eeee = 44;
// string text = "";

// text = Convert.ToString(eeee, 2);
// System.Console.WriteLine(text);



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3  -> 11
// 2  -> 10

// void ConverDecToBin(int number)
// {
//     string bin = "";
//     while(number > 0)
//     {
//         bin += Convert.ToString(number%2);
//         number = number/2;
//     }
//     char [] array = bin.ToCharArray();
//     Array.Reverse(array);
//     System.Console.WriteLine(string.Join("",array));
// }
// // ConverDecToBin(44);
// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void GetBinaryView(int num)
// {
//     if (num <= 0)
//     {
//         return;
//     }
//     GetBinaryView(num/2);
//     System.Console.Write(num%2);
// }

// // -------------------------

// int number = ReadInt("Введите число: ");
// GetBinaryView(number);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// void Fibonacci(int number){
//     System.Console.Write("0 1 ");
//     int n1 = 0;
//     int n2 = 1;
//     int result = 0;
//     for (int i = 2; i < number ; i++)
//     {
//         result = n1 + n2;
//         System.Console.Write(result+" ");
//         n1 = n2;
//         n2 = result;
//     }
// }

// int number = ReadInt("Введите число: ");
// Fibonacci(number);

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int[] CopyArray(int[] inputArray)
{
    int[] outputArray = new int[inputArray.Length];
    for(int i = 0; i < inputArray.Length; i++)
    {
        outputArray[i] = inputArray[i];
    }
    return outputArray;
}

// ---------------------
int[] array = FillArray(5, 0, 10);
// int[] arr2 = array; // копирует ссылку на массив, не выделяя память 
int[] arr2 = array[..]; // копирует массив поэлементно , с выделением памяти для нового массива
// int[] arr2 = CopyArray(array); // копирует массив поэлементно , аналогично предыдущему

array[0] = 100;
arr2[2] = 1000;

PrintArray(array);
PrintArray(arr2);

// -----------------------------
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // прием из консоли ввода 
