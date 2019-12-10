using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IPackage
    {
        int GetSizePackage();
        int GetId();
        void DeleteId();
        IBlock GetBlock();
        void SetBlock(Block block);
        string ShowPackage();
    }
}
