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
        public BestPackage()
        {
            minVerifier = new VerifierMinPackage();
        }

        public IPackage GetPackage(List<IPackage> packages)
        {
            var packageMinSize = packages[0];

            foreach (var item in packages)
            {
                if (minVerifier.VerifierPackage(packageMinSize, item) == true)
                {
                    packageMinSize = item;
                }

            }

            return packageMinSize;
        }
    }
}
