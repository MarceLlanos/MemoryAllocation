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

        public int GetSizeBlock()
        {
            return sizeBlock;
        }

        public List<IPackage> GetPackages()
        {
            return packages;
        }

        public void AddPackage(IPackage oldPackage, IPackage newPackage)
        {
            var resultPackage = oldPackage.GetSizePackage() - newPackage.GetSizePackage();

            for (int i = 0; i < packages.Count; i++)
            {
                if (packages[i] == oldPackage)
                {
                    packages[i] = newPackage;
                    newPackage.SetBlock(this);

                    if (resultPackage > 0)
                    {
                        packages.Insert(i + 1, new Package(resultPackage, 0, this));
                    }

                    break;
                }
            }
        }

        public string ShowBlock(int numberBlock)
        {
           return string.Format("Block {0}: size block: {1}", numberBlock, GetSizeBlock());
        }
    }
}
