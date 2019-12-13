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
            if (packages == null || packages.Count == 0)
            {
                return null;
            }

            var result = packages[0];

            foreach (var item in packages)
            {
                if (_verifier.VerifyPackages(item, result))
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
