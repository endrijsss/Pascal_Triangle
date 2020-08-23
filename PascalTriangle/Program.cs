using System;

namespace InterviewProgram.LogicalProgram
{
    class PascalTriangle
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number of rows : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }
                int val = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(val + " ");
                    val = val * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}