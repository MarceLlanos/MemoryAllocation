using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class CreatorPackage : ICreatorPackage
    {
        public IPackage CreatePackage(int sizePackage)
        {
            var result = new Package();
            result.SetSizePackage(sizePackage);
            return result;
        }
    }
}
