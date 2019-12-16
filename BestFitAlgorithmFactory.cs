using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BestFitAlgorithmFactory:IAllocateAlgorithmFactory
    {
        IAllocationMemoryAlgorithm bestAllocationAlgorithm;
        IVerifier minVerifier;

        public IAllocationMemoryAlgorithm CreateAllocationPackageAlgorithm()
        {
            minVerifier = new VerifierMinPackage();
            bestAllocationAlgorithm = new AllocationAlgorithmSetting(new VerifierVacatePackage(), new PackageVerifier(minVerifier));

            return bestAllocationAlgorithm;
        }
    }
}
