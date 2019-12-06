using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class VerifierMaxPackage : IVerifier
    {
        public bool VerifyPackages(IPackage firstPackage, IPackage secondPackage)
        {
            bool res = false;

            if (firstPackage.GetSizePackage() > secondPackage.GetSizePackage())
            {
                res = true;
            }

            return res;
        }
    }
}
