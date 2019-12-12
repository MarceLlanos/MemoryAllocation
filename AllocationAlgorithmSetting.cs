using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class AllocationAlgorithmSetting : IAllocationMemoryAlgorithm
    {
        IVerifier verifier;
        IPackageVerifier packageVerifier;

        public AllocationAlgorithmSetting(IVerifier verifier, IPackageVerifier packageVerifier)
        {
            this.verifier = verifier;
            this.packageVerifier = packageVerifier;
        }

        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            foreach (var item in blocks)
            {
                return new PackageVerifier(verifier, new VerifierVacatePackage()).CreatePackageVerified(item.GetPackages());
            }

            return null;
        } 
    }
}
