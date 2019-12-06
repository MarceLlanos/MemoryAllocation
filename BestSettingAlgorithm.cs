using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BestSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        IAllocateAlgorithmFactory bestAllocate;
        public BestSettingAlgorithm()
        {
            bestAllocate = new BestAlgorithmFactory();
        }
        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            
            foreach (var item in blocks)
            {
                var result = bestAllocate.FindValidPackage(item, package);
            }
            return null;
        } 
        

    }
}
