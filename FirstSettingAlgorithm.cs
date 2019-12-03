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
            var packages = new PackagesAvailable().AvailablePackages(blocks, package);
            if (packages != null)
            {
                foreach (var item in packages)
                {
                    return item;
                }
            }
            return null;

            /*foreach (var item in blocks)
            {
                foreach (var itemPackage in item.GetPackages())
                {
                    if (itemPackage.GetId() == 0 && itemPackage.GetSizePackage()>= package.GetSizePackage())
                    {
                        result = itemPackage;
                    }
                }
            }
            return result;*/
        }

        
    }
}
