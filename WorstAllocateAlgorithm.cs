using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class WorstAllocateAlgorithm : IAllocateAlgorithmFactory
    {
        public IPackage FindValidPackage(IBlock block, IPackage package)
        {
            var validPackages = new ValidatePackagesFactory().CreateValidPackages(block, package);
            var maxVerifier = new VerifierMaxPackage();
            var packageVerifier = new PackageVerifier(maxVerifier);

            foreach (var itemPackage in validPackages)
            {
                var verifiedPackage = maxVerifier.VerifyPackages(itemPackage, package);

                if (verifiedPackage)
                {
                    return packageVerifier.CreatePackageVerified(validPackages);
                }
            }
            return null;
        }
    }
}
