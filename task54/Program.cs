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

void SortMatrixMinMax(int[,] matrix) // Упорядочит по возрастанию элементы каждой строки.
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
      int minPosition = j;
      for (int k = j + 1; k < matrix.GetLength(1); k++)
      {
        if (matrix[i, k] < matrix[i, minPosition])
        {
          minPosition = k;
        }
      }
      int temp = matrix[i, j];
      matrix[i, j] = matrix[i, minPosition];
      matrix[i, minPosition] = temp;
    }
  }
}

// С использованием команды continue
//
// void SortMatrixMinMax(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//         {
//             if (matrix[i, j] > matrix[i, j + 1])
//             {
//                 int temp = matrix[i, j];
//                 matrix[i, j] = matrix[i, j + 1];
//                 matrix[i, j + 1] = temp;
//             }
//             else continue;
//             SortByLineMatrix(matrix);
//         }
//     }
// }


int m = ReadNumber("Введите количество строк матрицы: ");
int n = ReadNumber("Введите количество столбцов матрицы: ");

int[,] matr = GetMatrix(m, n);

Console.WriteLine("Исходная матрица:");
PrintMatrix(matr);
Console.WriteLine();

SortMatrixMinMax(matr);
Console.WriteLine("Отсортированная матрица:");
PrintMatrix(matr);
