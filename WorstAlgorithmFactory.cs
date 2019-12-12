using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class WorstAlgorithmFactory : IAllocateAlgorithmFactory
    {
        IAllocationMemoryAlgorithm worstAllocation;
        IVerifier maxVerifier;
        
        public IAllocationMemoryAlgorithm CreateAllocationPackageAlgorithm()
        {
            maxVerifier = new VerifierMaxPackage();
            worstAllocation = new AllocationAlgorithmSetting(new VerifierVacatePackage(), new PackageVerifier(maxVerifier));

            return worstAllocation;
        }
    }
}
