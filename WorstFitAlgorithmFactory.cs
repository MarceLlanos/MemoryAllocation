using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class WorstFitAlgorithmFactory : IAllocateAlgorithmFactory
    {
        
        public IAllocationMemoryAlgorithm CreateAllocationPackageAlgorithm()
        {
            var result = new AllocationAlgorithmSetting(new VerifierVacatePackage(), new PackageVerifier(new VerifierMaxPackage()));

            return result;
        }
    }
}
