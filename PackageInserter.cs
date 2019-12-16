using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class PackageInserter : IPackageInserter
    {

        public void InsertPackage(IDataInserter dataInserter, IBlock block)
        {
            if (dataInserter.GetSizeResult() > 0)
            {
                block.GetPackages().Insert(dataInserter.GetIndex() + 1, new Package(dataInserter.GetSizeResult(), 0, block));
            }
        }
    }
}
