using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class Memory : IMemory
    {
        IBlock[] blocks;
        IAllocationMemoryAlgorithm allocationAlgorithm;

        public Memory(IBlock[] blocks, IAllocationMemoryAlgorithm allocationAlgorithm)
        {
            this.blocks = blocks;
            this.allocationAlgorithm = allocationAlgorithm;
        }

        public bool AddPackageToMemory(IPackage package)
        {
            var packageFinded = allocationAlgorithm.FindPackage(blocks, package);

            if (packageFinded.GetSizePackage() >= package.GetSizePackage())
            {
                packageFinded.GetBlock().AddPackage(packageFinded, package);

                return true;
            }

            return false;
        }


        public IPackage DeleteById(int idPackage)
        {
            foreach (var item in blocks)
            {
                foreach (var itemPackage in item.GetPackages())
                {
                    if (itemPackage.GetId() == idPackage)
                    {
                        itemPackage.DeleteId();
                        return itemPackage;
                    }
                }
            }

            return null;
        }

        public void showMemory()
        {
            int numberBlock = 0;

            foreach (var item in blocks)
            {
                numberBlock++;
                item.ShowBlock(numberBlock);

                foreach (var itemPackage in item.GetPackages())
                {
                    itemPackage.ShowPackage();
                }
            }
        }
    }
}
