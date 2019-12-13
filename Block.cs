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
            var package = new Package(sizeBlock,0, this);
            packages.Add(package);
        }

        public int GetSizeBlock()
        {
            return sizeBlock;
        }

        public List<IPackage> GetPackages()
        {
            return packages;
        }

        public void Insert(int index, int sizeResult)
        {
            if (sizeResult > 0)
            {
                packages.Insert(index+1, new Package(sizeResult,0, this));
            }
           
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

        public void ShowBlock(int numberBlock)
        {
            string.Format("Block {0}: size block: {1}", numberBlock, GetSizeBlock());
            Console.WriteLine("Package Counter {0}", packages.Count);

            if (packages!= null || packages.Count > 0)
            {
                foreach (var item in packages)
                {
                    Console.WriteLine(item.ShowPackage());
                }
            }
        }
    }
}
