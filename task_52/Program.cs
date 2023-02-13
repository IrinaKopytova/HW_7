// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillArrayWithRandom(int[,] matrix, int m, int n)
    {
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                matrix[i,j] = new Random().Next(0, 11);
                Console.Write(matrix[i,j] + "\t");
            }
        Console.WriteLine();
        }
        Console.WriteLine();
    }

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m, n];
FillArrayWithRandom(matrix, m, n);


for (int j = 0; j < matrix.GetLength(0); j++)
{
    double s = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        s += matrix[i, j];
    }
    s /= matrix.GetLength(0);
    Console.Write(s + "; ");
}
Console.WriteLine();
