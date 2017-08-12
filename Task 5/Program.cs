using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {



        static void Main(string[] args)
        {
            // Вводим значение N
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];      // Матрица n-ого порядка 
            char[] ch = { ' ' };
            // Считываем значение матрицы по строкам и запоминаем
            for (int i = 0; i < N; i++)
            {
                string[] str = Console.ReadLine().Split(ch, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < str.Length; j++)
                    
                    matrix[i, j] = Int16.Parse(str[j]);
            }

            int[] b = new int[N];
            b[0] = 1;
            for (int i = 1; i< N; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < i; j++)
                    if (matrix[i, j] < min) min = matrix[i, j];
                b[i] = min;
            }

            for (int i = 0; i < N; i++)
                Console.Write("{0} ", b[i]);
            Console.ReadLine();
        }
    }
}
