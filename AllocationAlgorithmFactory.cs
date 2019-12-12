using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class AllocationAlgorithmFactory : IAllocationAlgorithmFactory
    {
        public IAllocationMemoryAlgorithm CreateAllocationAlgorithm(string algorithmOption)
        {
            
            switch (algorithmOption)
            {
                case "First Setting Allocation":
                    return new FirstSettingAlgorithm(new VerifierVacatePackage());
                case "Best Setting Allocation":
                    return new BestAlgorithmFactory().CreateAllocationPackageAlgorithm();
                case "Wrost Setting Allocation":
                    return new WorstAlgorithmFactory().CreateAllocationPackageAlgorithm();
                default:
                    return new FirstSettingAlgorithm(new VerifierVacatePackage());
            }
        }
    }
}
