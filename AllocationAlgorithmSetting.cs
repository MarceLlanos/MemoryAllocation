using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class AllocationAlgorithmSetting : IAllocationMemoryAlgorithm
    {
        IVacatePackages vacatePackages;
        IVerifier verifier;
        IPackageVerifier packageVerifier;

        public AllocationAlgorithmSetting( IVerifier verifier, IPackageVerifier packageVerifier)
        {
            this.verifier = verifier;
            this.packageVerifier = packageVerifier;
            packageVerifier = new PackageVerifier(verifier);
        }

        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            foreach (var item in blocks)
            {
                return packageVerifier.CreatePackageVerified(item.GetPackages());

            }
            return null;
        } 
    }
}
