// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;
Clear();


WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
int [] NewArray = GetArray(n);
//PrintArray(NewArray);
WriteLine($"Заданный массив [{String.Join(", ",NewArray)}]");


int min = 0;
int max = 0;
foreach (int i in NewArray)
{
    if (min > i) min = i;
    if (max < i) max = i;
}

WriteLine($"Разница между между максимальным ({max}) и минимальным({min}) элементами массива: {max-min}");
WriteLine();


int [] GetArray (int n)
{
int [] array = new int[n];
for (int i = 0;  i<n; i++)
    {
       array [i]= new Random().Next (-100, 100);  
    }
       return array;
       }

//void PrintArray(int[] Mass)
//{
//    Write("[");
//    for (int i = 0;  i<Mass.Length; i++)
//    {
//      Write (Mass[i] + ", ");
//    }
//    Write("]");
//}