// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int [,] FillMatrix(int rows, int columns)    // заполнение матрицы
{
    int [,] matrix = new int [rows, columns];
    for (int i=0; i<matrix.GetLength(0); i++)   // гетденгс узнает длину массива, 0 отв за строки, 1 за столбцы
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  //печать матрицы
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        } 
        Console.WriteLine("");
    }
}

Console.WriteLine("Введите размернось первого двумерного массива m * n");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());  // ввод матрицы
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = FillMatrix(m,n);
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Введите размернось второго двумерного массива a * b");
Console.WriteLine("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());  // ввод матрицы
Console.WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = FillMatrix(a,b);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrix3= new int [m,b];
    for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      matrix3[i,j] = sum;
    }
  }
Console.WriteLine("Произведение двух матриц: ");
PrintMatrix(matrix3);



