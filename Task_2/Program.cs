// Задача 43.
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Кординаты точки пересечения двух прямых: 
// х = (b1 - b2)/(k2-k1)
// y = (k2*b1 - k1*b2)/(k2-k1)

Console.WriteLine("Введите значение b1: ");
string b1 = Console.ReadLine();
double intb1 = Convert.ToDouble(b1);

Console.WriteLine("Введите значение k1: ");
string k1 = Console.ReadLine();
double intk1 = Convert.ToDouble(k1);

Console.WriteLine("Введите значение b2: ");
string b2 = Console.ReadLine();
double intb2 = Convert.ToDouble(b2);

Console.WriteLine("Введите значение k2: ");
string k2 = Console.ReadLine();
double intk2 = Convert.ToDouble(k2);

double x = (intb1 - intb2)/(intk2-intk1);
double y = (intk2*intb1 - intk1*intb2)/(intk2-intk1);

Console.Write("Кординаты точки пересечения двух прямых:");
Console.WriteLine(x);
Console.WriteLine(y);


