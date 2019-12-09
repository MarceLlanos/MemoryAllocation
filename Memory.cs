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
            bool result = false;

            var packageFinded = allocationAlgorithm.FindPackage(blocks, package);

            if(packageFinded.GetSizePackage() == package.GetSizePackage())
            {
                packageFinded.GetBlock().ReplacePackage(packageFinded, package);

                return true;
            }

            if (packageFinded.GetSizePackage() >= package.GetSizePackage())
            {
                packageFinded.GetBlock().ReplacePackage(packageFinded, package);
                packageFinded.GetBlock().InsertPackage(packageFinded, package);

                return true;
            }

            return result;
        }

        public IPackage DeleteById(int idPackage)
        {
            foreach (var item in blocks)
            {
                if (item.GetPackages() == null || item.GetPackages().Count == 0 )
                {
                    return null;
                }

                foreach (var itemPackage in item.GetPackages())
                {
                    if (itemPackage.GetId() == idPackage)
                    {
                        var id = itemPackage.GetId() - itemPackage.GetId();
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
                var sizeBlock = item.GetSizeBlock();
                numberBlock += 1;
                Console.WriteLine("Block {0}: {1}", numberBlock, sizeBlock);
               
            }

            foreach (var item in blocks)
            {
                foreach (var itemPackage in item.GetPackages())
                {
                    Console.Write("Size Package: {0}  Id: {1} ", itemPackage.GetSizePackage(), itemPackage.GetId());
                    Console.ReadKey();
                }
            }
        }
    }
}
