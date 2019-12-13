using System.Collections.Generic;

namespace MemoryBestAllocation
{
    internal interface IInsert
    {
        IPackage VerifyPackages(List<IPackage> packages, IPackage package);

    }
}