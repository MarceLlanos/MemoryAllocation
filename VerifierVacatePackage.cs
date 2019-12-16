using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class VerifierVacatePackage : IVerifier
    {
        public bool VerifyPackages(IPackage firstPackage, IPackage secondPackage)
        {
            if (firstPackage.GetId() == 0 && firstPackage.GetSizePackage() >= secondPackage.GetSizePackage())
            {
                return true;
            }

            return false;
        }
    }
}
