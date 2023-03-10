// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateMatrix(int str, int column)
{
    double[,] matrix = new double[str, column];
    Random rand =new Random();
    for(int i = 0; i < str; i++)
    {
        for(int j = 0; j < column; j++)
        {
            matrix[i,j] = rand.Next(1, 10)+rand.NextDouble();
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

System.Console.WriteLine("Введите количество строк матрицы:");
int str = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количесвто столбцов матрицы:");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = GenerateMatrix (str, column);
PrintMatrix (matrix);