using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BestPackage : IBestWorstPackage
    {
        IVerifier minVerifier;

        public BestPackage(IVerifier verifier)
        {
            this.minVerifier = verifier;
        }

        public IPackage GetPackage(List<IPackage> packages)
        {
            var result = packages[0];

            foreach (var item in packages)
            {
                if (minVerifier.VerifierPackage(result, item))
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
