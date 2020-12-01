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
            MarkedColls = new bool[NumberOfColls];
            MarkedRows = new bool[NumberOfRows];
            HighlightedColls = new bool[NumberOfColls];
            HighlightedRows = new bool[NumberOfRows];
        }

        public int[,] Matrix { get; set; }
        
        public bool[] MarkedRows { get; } 
        
        public bool[] MarkedColls { get; }

        public bool[] HighlightedRows { get; }

        public bool[] HighlightedColls { get; }

        public int NumberOfRows
        {
            get 
            {
                return Matrix.GetLength(0);
            }
        }

        public int NumberOfColls
        {
            get
            {
                return Matrix.GetLength(1);
            }
        }

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
            Console.Write("".PadLeft(8));
            for (int i = 0; i < NumberOfColls; i++)
            {
                Console.Write((MarkedColls[i] ? "x" : "").PadLeft(8));
            }
            Console.WriteLine();
            for (int i = 0; i < NumberOfRows; i++)
            {
                Console.Write((MarkedRows[i] ? "x" : "").PadLeft(8));
                for (int j = 0; j < NumberOfColls; j++)
                {
                    if (HighlightedColls[j] || HighlightedRows[i])
                        Console.BackgroundColor = ConsoleColor.Green;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write($"{Matrix[i, j]}".PadLeft(8));
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
            
        }
    }
}
