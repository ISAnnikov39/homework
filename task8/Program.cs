/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void Printmatrix(int[,]matrix){

    for (int i = 0; i < matrix.GetLength(0); i++){

        for (int j = 0; j < matrix.GetLength(1); j++){

                System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void  Fillmatrix(int i, int j, int k, int [,] massiv){
   
    if( 0<=j && 0<=i
             && i !=massiv.GetLength(0)
             && j !=massiv.GetLength(1)
             && massiv[i,j] == 0){

            massiv[i,j] = ++k;

            if (j == 0) {Fillmatrix(i-1, j, k, massiv);}
        
                Fillmatrix(i,j+1, k, massiv);
                Fillmatrix(i+1,j, k, massiv);
                Fillmatrix(i,j-1, k, massiv);
                Fillmatrix(i-1,j, k, massiv);
                 
        } 
}

int i = 0;
int j = 0;
int k = 0;
int a = 4;
int b = 4;
int [,] mas = new int [a, b] ;

Fillmatrix(i, j, k, mas);
Printmatrix(mas);