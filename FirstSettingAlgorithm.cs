using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class FirstSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        public IPackage FindPackage(IBlock[] blocks)
        {
            IPackage package = new Package();
            

            foreach (var item in blocks)
            {
                foreach (var item1 in item.GetListPackage())
                {
                    if (package == item1)
                    {
                        return package = item1;
                    }
                }
            }

            return package;
            
        }

        public void FirstSettingAllocation(Package package)
        {
            var packageNode = new Block().GetListPackage();
            var block = new Block();
           
            foreach (var item in packageNode)
            {
                if (item.GetSizePackage() >= package.GetSizePackage() && item.GetId() == 0)
                {
                    block.AddPackage(package);
                }
            }
        }
    }
}
