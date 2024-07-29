// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

class Program
{
   static void Main(string[] args)
   {
       int[] array = { 1, 2, 5, 10, 30 };
       PrintArrayReversed(array, array.Length - 1);
   }
   static void PrintArrayReversed(int[] array, int index)
   {
       if (index >= 0)
       {
           Console.Write(array[index] + " ");
           PrintArrayReversed(array, index - 1);
       }
   }
}