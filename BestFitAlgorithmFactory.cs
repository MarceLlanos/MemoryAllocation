using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BestFitAlgorithmFactory:IAllocateAlgorithmFactory
    {
        public IAllocationMemoryAlgorithm CreateAllocationPackageAlgorithm()
        {
            var result = new AllocationAlgorithmSetting(new VerifierVacatePackage(), new PackageVerifier(new VerifierMinPackage()));

            return result;
        }
    }
}
