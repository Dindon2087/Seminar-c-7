//Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
// Console.WriteLine("Введите количество строк массива:");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = Getarray(rows, columns, 0, 10);
// PrintArray(array);

// double[,] Getarray (int m, int n, int min, int max)
// {
//     double[,] result = new double[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         result[i, j] = new Random().NextDouble() * (max - min);
//     }
// }
// return result;
// }

//     void PrintArray(double[,] inArray)
//     {
//         for (int i = 0; i < inArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < inArray.GetLength(1); j++)
//             {
//                 Console.Write($"{inArray[i, j]:F1}");
//             }
//             Console.WriteLine();
//         }

//     }

//Задача 50. Напишите программу, которая на вход принимает число, 
//и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите число:");
// int element = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// if (FindElement(array, element))
// { Console.WriteLine($"Число {element} есть в массиве"); }
// else
// { Console.WriteLine($"Число {element} отсутствует в массиве"); }



// void PrintArray(int[,] array)
// {
//     throw new NotImplementedException();
// }




// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// bool FindElement(int[,] Array, int el)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; i < Array.GetLength(1); j++)
//         {

//             if (array[i, j] == el)
//                 return true;
//         }
//     }
//     return false;
// }
// void Printarray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]:F1}");
//         }
//         Console.WriteLine();
//     }

// }
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Random random = new Random();
// int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("---------------------------");
// Console.WriteLine(arr.GetLength(0));
// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($"{ sum / arr.GetLength(0)} ");
// }
// Console.ReadLine();





