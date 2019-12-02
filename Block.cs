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

        public Block()
        {
            packages = new List<IPackage>();
        }
        
        public void AddPackage(Package package)
        {
            sizeBlock -= package.GetSizePackage();
            packages.Add(package);
        }
        public int GetSizeBlock()
        {
            return sizeBlock;
        }

        public List<IPackage> GetListPackage()
        {
            return packages;
        }
    }
}
