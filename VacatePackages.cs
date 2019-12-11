using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class VacatePackages : IVacatePackages
    {
        IVerifier verifyPackage;
        IPackageVerifier verifier;

        public VacatePackages(IVerifier verifyPackage, IPackageVerifier verifier)
        {
            this.verifyPackage = verifyPackage;
            this.verifier = verifier;
        }
        
        public IPackage VacatedPackages(IBlock[] blocks, IPackage package)
        {
            foreach (var item in blocks)
            {
                foreach (var itemPackage in item.GetPackages())
                {
                    if (verifyPackage.VerifyPackages(itemPackage, package))
                    {
                        return verifier.CreatePackageVerified(item.GetPackages());
                    }
                }
            }
            
            return null;
            
        }

    }
}
