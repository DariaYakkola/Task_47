Console.Write("Введите количество строк в двумерном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в двумерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] GetDoubleMatrix (int rows, int cols)
{
  double[,] matrix = new double[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i,j] = Math.Round(new Random().NextDouble() * new Random().Next(-10,11), 2);
    }
  }
  return matrix;
}
void PrintDoubleMatrix(double[,] array2D)
{
  int rows = array2D.GetLength(0);
  int cols = array2D.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      Console.Write(array2D[i,j] + "\t");
    }
    Console.WriteLine();
  }
}
double[,] matrix2D = GetDoubleMatrix(m, n);
PrintDoubleMatrix(matrix2D);

