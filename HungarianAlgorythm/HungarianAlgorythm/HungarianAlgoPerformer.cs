using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungarianAlgorythm
{
    public class HungarianAlgoPerformer
    {
        public CostMatrix CostMatrix { get; set; }

        public HungarianAlgoPerformer(CostMatrix costMatrix)
        {
            CostMatrix = costMatrix;
        }
    }
}
