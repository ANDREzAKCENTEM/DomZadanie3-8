// Урок 8. Двумерные массивы
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
//             else Console.Write($"{matrix[i, j],3} ");
//         }
//         Console.WriteLine("|");
//     }
// }

// void GetSortedMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//         {
//             for (int k = j + 1; k < matrix.GetLength(1); k++)
//             {
//                 if (matrix[i, j] < matrix[i, k])
//                 {
//                     int temp = matrix[i, j];
//                     matrix[i, j] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
// PrintMatrix(matrix);

// Console.WriteLine();

// GetSortedMatrix(matrix);
// PrintMatrix(matrix);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns]; 
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         //Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1} ");
//             else Console.WriteLine($"{matrix[i, j],1} ");
//         }
//     }
// }

// void RowSum(int[,] row)
// {
//     for (int i = 0; i < 4; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < 4; j++)
//         {
//             sum += row[i, j];
//         }
//     }
// }

// void SumMin(int[,] arrSum)
// {
//     int minSum = arrSum[0, 0];
//     int min = default;
//     for (int i = 0; i < 4; i++)
//     {
//         for (int j = 1; j < 4; j++)
//         {
//             if (minSum > arrSum[i, j])
//             {
//                 minSum = arrSum[i, j];
//                 min = i;
//             }
//         }
//     }
//     Console.WriteLine($"строка с наименьшей суммой элементов: {min}");
// }

// int[,] arr = CreateMatrixRndInt(4, 4, 1, 9);
// PrintMatrix(arr);

// RowSum(arr);
// SumMin(arr);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}  ");
//             else Console.Write($"{matrix[i, j],3} ");
//         }
//         Console.WriteLine("|");
//     }
// }

// int[,] MatrixMultipleSum(int[,] matrix1, int[,] matrix2)
// {
//     if (matrix1.GetLength(1) != matrix2.GetLength(0))
//     {
//         Console.WriteLine("Умножение не возможно");
//     }
//     int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {

//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             matrix3[i, j] = 0;
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//         }
//     }
//     return matrix3;
// }

// int[,] matr = CreateMatrixRndInt(2, 2, 1, 5);
// PrintMatrix(matr);

// Console.WriteLine();

// int[,] array2D = CreateMatrixRndInt(2, 2, 2, 6);
// PrintMatrix(array2D);

// Console.WriteLine();

// int[,] matr3 = MatrixMultipleSum(matr, array2D);
// Console.WriteLine("результирующая матрица : ");
// Console.WriteLine();
// PrintMatrix(matr3);

