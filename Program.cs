/*
//z0. Генерация 2мерного массива и вывод.
int[,] CreateRandom2dArray()   //int rows, int colums, int minValue, int maxValue
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colums];

for(int i =0; i< rows; i++)
      for(int j =0; j< colums; j++)
         array[i,j] = new Random().Next(minValue, maxValue + 1);

return array;
   
}

void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
     for(int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + "\t");

     Console.WriteLine();
   }
   Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/
/*
//1z.Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
int[,] Create2dArray(int rows, int colums)   
{
   int[,] array = new int[rows, colums];

   for(int i =0; i< rows; i++)
   {
      for(int j =0; j< colums; j++)
       {
           array[i,j] = i+j;
       }
   }
 return array;
   
}

void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
     for(int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + "\t");

     Console.WriteLine();
   }
   Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray(rows, colums);
Show2dArray(newArray);
*/
/*
//2z.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
int[,] array = new int[rows, colums];

for(int i = 0; i < rows; i++)
      for(int j =0; j < colums; j++)
         array[i,j] = new Random().Next(minValue, maxValue + 1);

return array;
   
}

int[,] CheckNum(int[,] array)   
{
   
   for(int i =0; i < array.GetLength(0); i +=2)
   {
      for(int j =0; j < array.GetLength(1); j +=2)
       {
           array[i,j] *= array[i,j];
       }
   }
 return array;
   
}

void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
     for(int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + "\t");

     Console.WriteLine();
   }
   Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(newArray);
CheckNum(newArray);
Show2dArray(newArray);
*/
/*
//3z.Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int[,] Create2drandomArray()
{
    Console.Write("Please input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of MinValue: ");
    int MinValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of MaxValue: ");
    int MaxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return array;
}
int SumMainDiagonal(int[,] array)
{
    int summ = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        summ += array[i,i];
    }
    return summ;
}

void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
     for(int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + "\t");

     Console.WriteLine();
   }
   Console.WriteLine();
}

int[,] newArray = Create2drandomArray();
Show2dArray(newArray);
Console.WriteLine($"Summ is {SumMainDiagonal(newArray)}");
*/
/*
//MyrepozCSDz006.
//Zadacha47.Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.
double[,] CreateRandomDouble2dArray(int rows, int colums)
{
  double[,] array = new double[rows, colums];
  Random random = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        //Console.Write("{0,6:F2}", array[i, j]);
    }
    Console.WriteLine();
  }
  return array;
}

void ShowDouble2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,6:F2}", array[i, j]); //Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }

}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

double[,] newArray = CreateRandomDouble2dArray(rows, colums);
ShowDouble2dArray(newArray);
*/
/*
//Zadacha52.Nesovsmp. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
            
int[,] array = new int[rows, colums];
Random2dArray(array);
Show2dArray(array);           
            
    for (int j = 0; j < array.GetLength(1); j++)
    {
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      average = (average + array[i, j]);
    }
      average = average / rows;
      Console.Write(average + " ");
    }
    Console.WriteLine();
              
void Random2dArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(0, 10);
}
}
}
           
void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
     for(int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + "\t");

     Console.WriteLine();
   }
   Console.WriteLine();
}
*/
/*
//Zadacha50.Nesmog. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [8, 8];
Random2dArray(array);
Show2dArray(array);        
if (rows > array.GetLength(0) || colums > array.GetLength(1))
{
Console.WriteLine("This element no");
}
else
{
Console.WriteLine($"Row and column element value is {array[rows-1,colums-1]}");
}
        
//Show2dArray(array);

void Random2dArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array [i,j] = new Random().Next(-100, 100)/10;
}
}
}
           
void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
     for(int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + "\t");

     Console.WriteLine();
   }
   Console.WriteLine();
}
*/






    

