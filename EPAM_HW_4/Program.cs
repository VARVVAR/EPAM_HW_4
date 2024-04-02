using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть рядкiв: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введiть кiлькiсть стовпчикiв: ");
            int m = int.Parse(Console.ReadLine());

            int[,] array = new int[n,m];
            Console.WriteLine($"Введiть {n * m} елементiв");

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    array[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nВихiднi данi масива:\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }

            int MaxSum = 0;
            int Index= 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int CurrentValue= 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    CurrentValue += array[i, j];
                }

                if (CurrentValue > MaxSum)
                {
                    MaxSum = CurrentValue;
                    Index = i;
                }
                else if (CurrentValue == MaxSum && i < Index)
                {
                    Index = i;
                }
            }

            Console.Write($"\nМаксимальна сума в рядку:  {Index}\n");
        }
    }
}
