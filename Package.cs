using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class Package : IPackage
    {
        int sizePackage;
        int idPackage;
        IBlock block;

        public Package(int sizePackage, int idPackage, IBlock block)
        {
            this.sizePackage = sizePackage;
            this.idPackage = idPackage;
            this.block = block;
        }

        public void DeleteId()
        {
            idPackage = 0;
        }

        public int GetId()
        {
            return idPackage;
        }

        public int GetSizePackage()
        {
            return sizePackage;
        }
        public IBlock GetBlock()
        {
            return block;
        }

        public void SetBlock(Block block)
        {
            this.block = block;
        }

        public string ShowPackage()
        {

            return string.Format("Package Data: id {0} size {1}", GetId(), GetSizePackage());
        }
    }
}
