using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class WorstSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            var packageResult = new WorstAllocateAlgorithm();

            foreach (var item in blocks)
            {
                return packageResult.FindValidPackage(item, package);
            }

            return null;
        }
    }
}
