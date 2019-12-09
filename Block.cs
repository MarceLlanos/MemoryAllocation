using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class Block : IBlock
    {
        int sizeBlock;
        List<IPackage> packages;

        public Block(int sizeBlock)
        {
            this.sizeBlock = sizeBlock;
            packages = new List<IPackage>();
            
        }

        public Block()
        {
            packages = new List<IPackage>();
        }

        public int GetSizeBlock()
        {
            return sizeBlock;
        }

        public List<IPackage> GetPackages()
        {
            return packages;
        }

        public void ReplacePackage(IPackage oldPackage, IPackage newPackage)
        {
            for (int i = 0; i < packages.Count; i++)
            {
                if (packages[i] == oldPackage)
                {
                    packages[i] = newPackage;
                    break;
                }
            }
        }

        public void InsertPackage(IPackage oldPackage, IPackage newPackage)
        {
            var listPackage = oldPackage.GetBlock().GetPackages();
            int index = listPackage.IndexOf(oldPackage);
            var resultPackage = oldPackage.GetSizePackage() - newPackage.GetSizePackage();
            newPackage = new Package(resultPackage, 0, oldPackage.GetBlock());
            listPackage.Insert(index,newPackage);
        }
    }
}
