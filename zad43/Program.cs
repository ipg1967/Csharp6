// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Для нахождения точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 введите k1: ");
float k1 = Convert.ToInt16(Console.ReadLine());

System.Console.WriteLine("ТЕперь введите b1: ");
float b1 = Convert.ToInt16(Console.ReadLine());

System.Console.WriteLine("Теперь введите k2: ");
float k2 = Convert.ToInt16(Console.ReadLine());

System.Console.WriteLine("и введите b2: ");
float b2 = Convert.ToInt16(Console.ReadLine());

float xxx = (b2 - b1) / (k1 - k2);
System.Console.WriteLine(Convert.ToString(xxx));
float yyy = (k1 * xxx) + b1;

System.Console.WriteLine($"Для коэффициентов k1={k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} точка пересечения прямых по этим функциям будет с координатами ({xxx};{yyy})");

