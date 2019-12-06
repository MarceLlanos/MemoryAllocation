using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class PackageFactory : IPackageFactory
    {
        public IPackage CreatePackage(int sizePackage, IBlock block)
        {

            IPackage result = null;
            
            if (sizePackage > 0)
            {
                var id = new GeneratorId().GenerateId();
                result = new Package(sizePackage, id, block);
            }

            return result;
        }
    }
}
