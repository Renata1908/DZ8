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

int MinSumRowMatrix(int[,] matrix) // Находит строку с наименьшей суммой элементов.
{
  int sum = 0;
  int minRow = 0;
  int minSum = 0;
  for (int i = 0; i < 1; i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      minSum += matrix[0, j];
      minRow = i;
    }
  }
  for (int i = 1; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum += matrix[i, j];
    }
    if (sum < minSum)
    {
      minSum = sum;
      minRow = i;
    }
    sum = 0;
  }
  return minRow;
}


int m = ReadNumber("Введите количество строк матрицы: ");
int n = ReadNumber("Введите количество столбцов матрицы: ");

int[,] matr = GetMatrix(m, n);

Console.WriteLine("Исходная матрица:");
PrintMatrix(matr);
Console.WriteLine();

int numberRow = MinSumRowMatrix(matr);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberRow} строка (по счету:  {numberRow + 1} строка)");

