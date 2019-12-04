using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class VerifierMinPackage : IVerifier
    {
        public bool VerifierPackage(IPackage firstPackage, IPackage secondPackage)
        {
            bool result = false;

            if (firstPackage.GetSizePackage() <= secondPackage.GetSizePackage())
            {
                result = true;
            }

            return result;
        }
    }
}
