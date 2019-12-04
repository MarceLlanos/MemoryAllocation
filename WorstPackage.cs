using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class WorstPackage : IBestWorstPackage
    {
        IVerifier maxVerifier;
        public WorstPackage()
        {
            maxVerifier = new VerifierMaxPackage();
        }

        public IPackage GetPackage(List<IPackage> packages)
        {
            var packageMaxSize = packages[0];

            foreach (var item in packages)
            {
                if (maxVerifier.VerifierPackage(packageMaxSize, item) == true)
                {
                    packageMaxSize = item;
                }

            }

            return packageMaxSize;
        }
    }
}
