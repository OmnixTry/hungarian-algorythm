using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungarianAlgorythm
{
    public class CostMatrix
    {
        public CostMatrix(int[,] matrix)
        {
            Matrix = matrix;
            MarkedColls = new bool[matrix.GetLength(1)];
            MarkedRows = new bool[matrix.GetLength(0)];
        }

        public int[,] Matrix { get; set; }
        
        public bool[] MarkedRows { get; } 
        
        public bool[] MarkedColls { get; }

        public void SubstractFromRow(int rowNumber, int number)
        {
            int lengthOfRow = Matrix.GetLength(1);
            for (int i = 0; i < lengthOfRow; i++)
                Matrix[rowNumber, i] -= number;
        }

        public void SubstractFromColl(int collNumber, int number)
        {
            int lengthOfRow = Matrix.GetLength(0);
            for (int i = 0; i < lengthOfRow; i++)
                Matrix[i, collNumber] -= number;
        }

        public int GetMinOfTheRow(int rowNumber)
        {
            return Enumerable.Range(0, Matrix.GetLength(1))
                .Select(n => Matrix[rowNumber, n])
                .Min(x => x);
        }

        public int GetMinOfTheColl(int rowNumber)
        {
            return Enumerable.Range(0, Matrix.GetLength(0))
                .Select(n => Matrix[n, rowNumber])
                .Min(x => x);
        }

        public void Display()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j]}".PadLeft(8));
                }
                Console.WriteLine();
            }                
        }
    }
}
