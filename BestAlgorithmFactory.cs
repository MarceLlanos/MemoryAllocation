using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BestAlgorithmFactory:IAllocateAlgorithmFactory
    {
        IAllocationMemoryAlgorithm bestAllocationAlgorithm;
        IVerifier minVerifier;
        IPackageVerifier packageVerifier;

        public IAllocationMemoryAlgorithm CreateAllocationPackageAlgorithm()
        {
            minVerifier = new VerifierMinPackage();
            packageVerifier = new PackageVerifier(minVerifier);
            bestAllocationAlgorithm = new AllocationAlgorithmSetting(new VerifierVacatePackage(), packageVerifier);

            return bestAllocationAlgorithm;
        }
    }
}
