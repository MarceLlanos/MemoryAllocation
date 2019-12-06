using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class UnifierPackage : IUnifierPackage
    {
        public void UnifyPackage(List<IPackage> packages)
        {
            if (packages != null)
            {
                for (int i = 0; i < packages.Count; i+=2)
                {
                    if( packages[i].GetId() == 0 && packages[i+1].GetId() == 0)
                    {
                        var result = packages[i].GetSizePackage() + packages[i + 1].GetSizePackage();
                    }
                }
            }
            
        }
    }
}
