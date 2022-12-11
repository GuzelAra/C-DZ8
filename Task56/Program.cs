// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

int [,] FillMatrix(int rows, int columns)    
{
    int [,] matrix = new int [rows, columns];
    for (int i=0; i<matrix.GetLength(0); i++)   
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) 
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

Console.WriteLine("Введите размернось двухмерного массива m *n");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());  // ввод матрицы
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
int index = 0;
int minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        // Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }

    Console.WriteLine($"Строка с минимальной суммой элементов равна {index+1}. ");


