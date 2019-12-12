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
        IUnifierPackage unifierPackage;

        public Memory(IBlock[] blocks, IAllocationMemoryAlgorithm allocationAlgorithm, IUnifierPackage unifierPackage)
        {
            this.blocks = blocks;
            this.allocationAlgorithm = allocationAlgorithm;
            this.unifierPackage = unifierPackage;
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
            IPackage result = null;
            
            foreach (var item in blocks)
            {
                foreach (var itemPackage in item.GetPackages())
                {

                    if (itemPackage.GetId() == idPackage)
                    {
                        itemPackage.DeleteId();

                        result = itemPackage;
                        break;
                    }
                }

                if (result != null)
                {
                    break;
                }
            }

            if (result != null)
            {
                unifierPackage.UnifyPackage( result.GetBlock().GetPackages() );

            }

            return result;
        }

        public void showMemory()
        {
            int number = 0;
            Console.WriteLine("Block counter {0}", blocks.Length);
            foreach (var item in blocks)
            {
                item.ShowBlock(number++);
            }
        }
    }
}
