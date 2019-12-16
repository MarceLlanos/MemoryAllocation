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
            IAllocationMemoryAlgorithm worstAllocation;
            IVerifier maxVerifier;

            maxVerifier = new VerifierMaxPackage();
            worstAllocation = new AllocationAlgorithmSetting(new VerifierVacatePackage(), new PackageVerifier(maxVerifier));

            return worstAllocation;
        }
    }
}
