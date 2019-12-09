using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class PackageFactory : IPackageFactory
    {
        IGeneratorId idGenerator;

        public PackageFactory(IGeneratorId idGenerator)
        {
            this.idGenerator = idGenerator;
        }

        public IPackage CreatePackage(int sizePackage, IBlock block)
        {
            return new Package(sizePackage, idGenerator.GenerateId(), block);
        }
    }
}
