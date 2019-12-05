using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class FirstSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        

        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            var packages = new ValidatePackagesFactory();

            foreach (var item in blocks)
            {
                foreach (var itemPackage in packages.CreateValidPackages(item, package))
                {
                    return itemPackage;
                }
            }
            
            return null;
        }

        
    }
}
