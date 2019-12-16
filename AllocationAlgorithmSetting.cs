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

        public IPackage FitPackage(IBlock[] blocks, IPackage package)
        {
            var packages = new List<IPackage>();

            foreach (var item in blocks)
            {
                foreach (var itemPackages in item.GetPackages())
                {
                    if (verifier.VerifyPackages(itemPackages, package))
                    {
                        packages.Add(itemPackages);
                    }
                }
            }

            return packageVerifier.CreatePackageVerified(packages);
        } 
    }
}
