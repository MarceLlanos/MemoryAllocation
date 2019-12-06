﻿using System;
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
    }
}
