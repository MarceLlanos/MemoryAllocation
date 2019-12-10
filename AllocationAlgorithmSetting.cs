using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class AllocationAlgorithmSetting : IAllocationMemoryAlgorithm
    {
        IAllocateAlgorithmFactory bestAllocate;
        IVacatePackages vacatePackages;
        IVerifier verifier;
        IPackageVerifier packageVerifier;

        public AllocationAlgorithmSetting( IVerifier verifier, IPackageVerifier packageVerifier)
        {
            vacatePackages = new VacatePackages();
            this.verifier = verifier;
            this.packageVerifier = packageVerifier;

            bestAllocate = new BestAlgorithmFactory();
        }

        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            if (vacatePackages.VacatedPackages(blocks, package) == null || vacatePackages.VacatedPackages(blocks, package).Count ==0)
            {
                return null;
            }

            foreach (var item in vacatePackages.VacatedPackages(blocks, package))
            {
                if (verifier.VerifyPackages(item, package))
                {
                    return packageVerifier.CreatePackageVerified(vacatePackages.VacatedPackages(blocks, package));
                }
            }
            return null;
        } 
    }
}
