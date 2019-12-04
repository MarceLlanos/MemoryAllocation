using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BiggerPackage : IBestWorstPackage
    {
        IVerifier maxVerifier;

        public BiggerPackage( IVerifier verifier)
        {
            this.maxVerifier = verifier;
        }

        public IPackage GetPackage(List<IPackage> packages)
        {
            var result = packages[0];

            foreach (var item in packages)
            {
                if (maxVerifier.VerifierPackage(result, item))
                {
                    result = item;
                }
                else
                {
                    result = null;
                }
            }

            return result;
        }
    }
}
