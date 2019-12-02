using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class FirstSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        

        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            IPackage result = new Package();

            foreach (var item in blocks)
            {
                if (item.GetSizeBlock() >= package.GetSizePackage())
                {
                    result = package;
                }
            }

            return result;
        }
    }
}
