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
            var packages = new AvailablePackages().GetAvailablePackages(blocks, package);
             
            if (packages != null)
            {
                foreach (var item in packages)
                {
                    return item;
                }
            }
            return null;
        }

        
    }
}
