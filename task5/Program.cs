/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
int[,]table = new int[a, b];

void FillArray( int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,]matrix){

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void MinRow(int[,]matrix){

    
   int [] array = new int[matrix.GetLength(0)];
   int result = 1;
    for (int i = 0; i < matrix.GetLength(0); i++){

         int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++){
            sum += matrix[i,j];
        }
        array [i] = sum;
    }
    
        int minRow =array [0];
        for (int k = 1; k < array.Length ; k++){    
        
        if (array[k]<minRow){
            minRow = array[k];
            result = k+1;
        }
        
    }System.Console.WriteLine(result);
    
}



FillArray(table);
PrintArray(table);
System.Console.WriteLine();
MinRow(table);