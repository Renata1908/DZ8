int ReadNumber(string message) // Ввод числа из консоли.
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rows, int columns, int leftRange = -10, int rightRange = 10) // Наполнение массива случайными числами.
{
  int[,] matrix = new int[rows, columns];
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rand.Next(leftRange, rightRange + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix) // Вывод массива в консоль.
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}

int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
  int[,] matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = matrix1[i, j] * matrix2[i, j];
    }
  }
  return matrix;
}

int m = ReadNumber("Введите количество строк матрицы: ");
int n = ReadNumber("Введите количество столбцов матрицы: ");

int[,] matr1 = GetMatrix(m, n);
int[,] matr2 = GetMatrix(m, n);

Console.WriteLine("Первая матрица:");
PrintMatrix(matr1);
Console.WriteLine();

Console.WriteLine("Вторая матрица:");
PrintMatrix(matr2);
Console.WriteLine();

int[,] resMatr = MultiMatrix(matr1, matr2);
Console.WriteLine("Проиведение матриц 1 и 2:");
PrintMatrix(resMatr);
