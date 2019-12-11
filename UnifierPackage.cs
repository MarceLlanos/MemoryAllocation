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
            
            for (int i = 0; i < packages.Count;)
            {
                if (packages[i].GetId() == 0 && packages[i + 1].GetId() == 0)
                {
                    var  size = packages[i].GetSizePackage() + packages[i+1].GetSizePackage();

                    packages[i] = new Package(size, 0, packages[i].GetBlock());

                    packages.Remove(packages[i+1]);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
