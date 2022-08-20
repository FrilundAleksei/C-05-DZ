// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


using static System.Console;
Clear();

WriteLine("Какое число цыфр должно быть в массиве?");
int size = Convert.ToInt32(ReadLine());

int [] NewArray = GetArrey(size);
WriteLine($"[{String.Join(", ",NewArray)}]");

int count = 0;
for (int i = 0; i < NewArray.Length; i++)
{
    if(NewArray[i]%2==0)
    {
        count+=1;
    }
}
   Console.WriteLine($"В массиве всего {NewArray.Length} чисел, {count} из них чётные.");





int [] GetArrey (int N)
{
int [] array = new int[N];
for (int i = 0;  i<N; i++)
    {
       array [i]= new Random().Next (100, 1000);  
    }
       return array;
 }






