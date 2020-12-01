using HungarianAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 2500, 4000, 3500}, { 4000, 6000, 3500}, { 2000, 4000, 2500} };
            CostMatrix costMatrix = new CostMatrix(matrix);
            costMatrix.HighlightedRows[0] = true;
            costMatrix.HighlightedColls[2] = true;
            costMatrix.MarkedColls[1] = true;
            costMatrix.MarkedRows[2] = true;
            costMatrix.Display();
            /*            Console.WriteLine();
                        costMatrix.SubstractFromColl(1, 500);            
                        costMatrix.Display();
                        Console.WriteLine();
                        costMatrix.SubstractFromRow(0, 500);
                        costMatrix.Display();
                        Console.WriteLine();*/
            /*
                        Console.WriteLine(costMatrix.GetMinOfTheRow(0));
                        Console.WriteLine(costMatrix.GetMinOfTheRow(1));
                        Console.WriteLine(costMatrix.GetMinOfTheRow(2));
                        Console.WriteLine();
                        Console.WriteLine(costMatrix.GetMinOfTheColl(0));
                        Console.WriteLine(costMatrix.GetMinOfTheColl(1));
                        Console.WriteLine(costMatrix.GetMinOfTheColl(2));*/

            HungarianAlgoPerformer performer = new HungarianAlgoPerformer(costMatrix);
            performer.Execute();
            costMatrix.Display();





        }
    }
}
