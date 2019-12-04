using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class PackageFactory : IPackageFactory
    {
        public IPackage CreatePackage(int sizePackage)
        {
            var result = new Package(sizePackage);
            return result;
        }
    }
}
