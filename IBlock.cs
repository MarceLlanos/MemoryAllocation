using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IBlock
    {
        int GetSizeBlock();
        List<IPackage> GetPackages();
        void AddPackage(IPackage oldPackage, IPackage newPackage);
        string ShowBlock(int numberBlock);



    }
}
