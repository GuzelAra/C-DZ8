// // Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int [,,] FillMatrix(int rows, int columns, int lists)    
{
    int [,,] matrix = new int [rows, columns,lists];
    for (int i=0; i<matrix.GetLength(0); i++)   
    {
        for (int j=0; j<matrix.GetLength(1); j++)
            {
                 for (int k = 0; k < matrix.GetLength(2); k++)
                     {
                        matrix[i, j, k] = new Random().Next(0, 11);
                    }
            }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix) 
{
    for (int k=0; k<matrix.GetLength(2); k++)
    {
        for (int i=0; i<matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
                    } 
                    Console.WriteLine("");
            }
    }
}
Console.WriteLine("Введите размернось трехмерного массива m*n*p");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());  // ввод матрицы
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите p: ");
int p = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = FillMatrix(m,n,p);
PrintMatrix(matrix);
Console.WriteLine();