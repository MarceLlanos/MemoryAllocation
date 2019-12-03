using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class MaximumMinimumPackage
    {     

        public IPackage GetMinimunPackage(List<IPackage> packages)
        {
            var packageMinSize = packages[0];

            foreach (var item in packages)
            {
                return Minimum(packageMinSize, item);
            }

            return null;
        }

        public IPackage GetMaximunPackage(List<IPackage> packages)
        {
            var packageMaxSize = packages[0];

            foreach (var item in packages)
            {
                return Maximum(packageMaxSize, item);
            }

            return null;
        }

        private IPackage Minimum(IPackage packageMinSize, IPackage package)
        {
            if (package.GetSizePackage() <= packageMinSize.GetSizePackage())
            {
                packageMinSize = package;
            }

            return packageMinSize;
        }

        private IPackage Maximum(IPackage packageMaxSize, IPackage package)
        {
            if (package.GetSizePackage() > packageMaxSize.GetSizePackage())
            {
                packageMaxSize = package;
            }

            return packageMaxSize;
        }

        
    }
}
