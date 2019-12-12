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

        public PackageVerifier( IVerifier verifier)
        {
            this._verifier = verifier;
        }

        public IPackage CreatePackageVerified(List<IPackage> packages)
        {
            var result = packages[0];

            foreach (var item in packages)
            {
                if (_verifier.VerifyPackages(result, item))
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
