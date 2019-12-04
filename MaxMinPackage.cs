using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class MaxMinPackage
    {
        
        public IPackage GetMinimunPackage(List<IPackage> packages)
        {
            var packageMinSize = packages[0];

            foreach (var item in packages)
            {
                if (item.GetSizePackage() <= packageMinSize.GetSizePackage())
                {
                    packageMinSize = item;
                }
                
            }

            return packageMinSize;
        }

        public IPackage GetMaximunPackage(List<IPackage> packages)
        {
            var packageMaxSize = packages[0];

            foreach (var item in packages)
            {

                if (item.GetSizePackage() > packageMaxSize.GetSizePackage())
                {
                    packageMaxSize = item;
                }

            }
            return packageMaxSize;
        }                
    }
}
