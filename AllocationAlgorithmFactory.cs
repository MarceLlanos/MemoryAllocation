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
                    return new FirstFitAlgorithm(new VerifierVacatePackage());
                case "Best Setting Allocation":
                    return new BestFitAlgorithmFactory().CreateAllocationPackageAlgorithm();
                case "Wrost Setting Allocation":
                    return new WorstFitAlgorithmFactory().CreateAllocationPackageAlgorithm();
                default:
                    return new FirstFitAlgorithm(new VerifierVacatePackage());
            }
        }
    }
}
