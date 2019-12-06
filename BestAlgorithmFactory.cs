using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BestAlgorithmFactory:IAllocateAlgorithmFactory
    {
        
        public IPackage FindValidPackage(IBlock block, IPackage package)
        {
            var validPackages = new ValidatePackagesFactory().CreateValidPackages(block, package);
            var minVerifier = new VerifierMinPackage();
            var packageVerifier = new PackageVerifier(minVerifier);
            

            foreach (var itemPackage in validPackages)
            {
                var verifiedPackage = minVerifier.VerifyPackages(itemPackage, package);
                    
                if (verifiedPackage)
                {
                    return packageVerifier.CreatePackageVerified(validPackages);
                }
            }
            return null;
        }
    }
}
