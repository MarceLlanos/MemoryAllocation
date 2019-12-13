using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class Insert:IInsert
    {
        public IPackage VerifyPackages(List<IPackage> packages, IPackage package)
        {
            foreach (var item in packages)
            {
                if (item == package)
                {
                    return item;
                }
                break;
            }
            return null;
        }
    }
}
