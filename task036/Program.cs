//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



using static System.Console;
Clear();

WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(ReadLine());

int [] NewArray = GetArrey(size);
WriteLine($"Заданный массив [{String.Join(", ",NewArray)}]");

// var sum = NewArray.Where((n, i) => (i++ % 2) == 0).Sum();
// WriteLine($"Cумма элементов, стоящих на нечётных позициях в заданно массиве = {sum}.");

double Sum = 0;
            for (int i = 0; i < size; i += 2)
            {
                Sum += NewArray[i];
            }
            WriteLine($"Cумма элементов, стоящих на нечётных позициях в заданно массиве = {Sum}.");
  


int [] GetArrey (int N)
{
int [] array = new int[N];
for (int i = 0;  i<N; i++)
    {
       array [i]= new Random().Next (-100, 100);  
    }
       return array;
 }