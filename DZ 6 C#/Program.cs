// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine();
// int M = 5; 
// int count = 0;

// while (M > 0)
// {
// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// int number = Convert.ToInt32(num);
// if (number > 0) count++;
// M--;
// }
// Console.WriteLine($"Количество чисел больше 0: {count}");
// Console.WriteLine();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 Console.WriteLine("Две прямые заданны уравнениями: y = k1 * x + b1 и y = k2 * x + b2");
 Console.WriteLine("Задайте значения: b1, k1, b2, k2 последовательно, по одному: ");
 double[]array=new double[4];
 void FillArray(double[]collection)
 {
 string [] arr = new string [] {"b1", "k1", "b2", "k2"};
 int length = 4;
 int index = 0;
 while (index < length)
     {
 Console.WriteLine($"Введите значение {arr[index]}");
 double n=Convert.ToInt32(Console.ReadLine());
 collection[index]=n;
 index++;
     }
 }
// // // b1, k1, b2, k2 <= значения
// // // 0, 1, 2, 3 <= индексы
 FillArray(array);

 double x = (array[2]-array[0])/(array[1]-array[3]);
 double y = (array[1]*x + array[0]);
 if(array[1] == array[3] ) Console.Write("Заданные прямые не пересекаются!");
 else Console.WriteLine($"Точка пересечения двух прямых ({x}, {y})");