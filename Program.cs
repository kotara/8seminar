// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] Create2dRandomArray (int rows, int cols, int min, int max)
{
    int [,] array = new int [rows, cols];
    if (array.GetLength(0) == array.GetLength(1)){
    
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}
else {
    Console.WriteLine("Incorrect value");
    return array;
}
}

void Show2dArray (int [,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


void OrderRows(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

Console.Write("Input rows numb: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input cols numb: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min numb: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max numb: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dRandomArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();

OrderRows(array);
Show2dArray(array);
*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int [,] Create2dRandomArray (int rows, int cols, int min, int max)
{
    int [,] array = new int [rows, cols];
    if (array.GetLength(0) == array.GetLength(1)){
    
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}
else {
    Console.WriteLine("Incorrect value");
    return array;
}
}

void Show2dArray (int [,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}





Console.Write("Input rows numb: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input cols numb: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min numb: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max numb: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dRandomArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"{minSumLine+1} row - row with less summ of elements ({sumLine})");
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int [,] Create2dRandomArray (int rows, int cols, int min, int max)
{
    int [,] array = new int [rows, cols];
    if (array.GetLength(0) == array.GetLength(1)){
    
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}
else {
    Console.WriteLine("Incorrect value");
    return array;
}
}

void Show2dArray (int [,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.Write("Input rows numb: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input cols numb: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min numb: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max numb: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] matrixOne = Create2dRandomArray(rows, cols, min, max);
int [,] matrixTwo = Create2dRandomArray(rows, cols, min, max);
Console.WriteLine($"First Matrix: ");
Show2dArray(matrixOne);
Console.WriteLine();
Console.WriteLine($"Second Matrix: ");
Show2dArray(matrixTwo);
Console.WriteLine();

int[,] resultMatrix = Create2dRandomArray(rows, cols, min, max);
MultiplyMatrix(matrixOne, matrixTwo, resultMatrix);
Console.WriteLine($"Multiply of your matrix is: ");
Show2dArray(resultMatrix);
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
/*
void Create3DArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void Show3DArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
          Console.Write($"{array3D[i,j,k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
  }
}



Console.Write("Input massive X numb: ");
int Xnumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Input massive Y numb: ");
int Ynumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Input massive Z numb: ");
int Znumb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int[,,] array3D = new int[Xnumb, Ynumb, Znumb];
Create3DArray(array3D);
Show3DArray(array3D);


*/


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] Create2dRandomArray (int rows, int cols, int min, int max)
{
    int [,] array = new int [rows, cols];
    if (array.GetLength(0) == array.GetLength(1)){
    
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}
else {
    Console.WriteLine("Incorrect value");
    return array;
}
}

void Show2dArray (int [,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
          if (array[i,j] / 10 <= 0)
            Console.Write($"0{array[i,j]} ");
          else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int rows = 4;
int cols = 4;
int min = 1;
int max = 99;

int [,] array = Create2dRandomArray(rows, cols, min, max);

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

Show2dArray(array);
Console.WriteLine();