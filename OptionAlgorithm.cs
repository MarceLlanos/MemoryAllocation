using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class OptionAlgorithm:IOptionAlgorithm
    {
        public string Option(int option)
        {
            switch (option)
            {
                case 1:
                    return "First Setting Allocation";
                case 2:
                    return "Best Setting Allocation";
                case 3:
                    return "Wrost Setting Allocation";
                default:
                    return "First Setting Allocation";
            }
        }
    }
}
