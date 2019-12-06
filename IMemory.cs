using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IMemory
    {
        bool AddPackageToMemory(IPackage package);
        IPackage DeleteById(int idPackage);
        void showMemory();
    }
}
