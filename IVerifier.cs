using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IVerifier
    {
        bool VerifierPackage(IPackage firstPackage, IPackage secondPackage);
    }
}
