using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class PackageVerifier : IPackageVerifier
    {
        IVerifier _verifier;
        IVerifier filterPackage;

        public PackageVerifier( IVerifier verifier, IVerifier filterPackage)
        {
            this._verifier = verifier;
            this.filterPackage = filterPackage;
        }

        public IPackage CreatePackageVerified(List<IPackage> packages)
        {
            var result = packages[0];

            foreach (var item in packages)
            {
                if (filterPackage.VerifyPackages(result, item) && _verifier.VerifyPackages(result, item))
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
