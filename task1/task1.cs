string[,] table = new string [2, 5]; // Задали многомерный массив (таблицу)

// String.Empty
// table [0,0] table [0,1] table [0,2] 
// table [1,0] table [1,1] table [1,2]

 

// table [1, 2] = " +"; // Присвоить значение "слово" в 1 строку во 2 столбец

// for (int rows = 0; rows < 2; rows++) // Цикл на строки
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.Write($"-{table[rows, columns]} ");
//     }
//     Console.WriteLine();
// }

int [,] matrix = new int [3,4];

void PrintArray (int [,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
}

void FillArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1; 10]
        }
    }
}


PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
