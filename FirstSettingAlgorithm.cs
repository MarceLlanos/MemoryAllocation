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
                    if (item1.GetId() == 0 && item1.GetSizePackage() >= package.GetSizePackage())
                    {
                        item.GetListPackage().Add(package);
                        package = item1;
                    }
                }
            }
            return package;
        }

        public void FirstSettingAllocation(Package package)
        {
            var listPackage = new Block().GetListPackage();
            var block = new Block();

            if (block.GetSizeBlock() >= package.GetSizePackage())
            {
                foreach (var item in listPackage)
                {
                    if (item.GetSizePackage() >= package.GetSizePackage() && item.GetId() == 0)
                    {
                        listPackage.Add(package);
                    }
                }
            }
            
        }
    }
}
