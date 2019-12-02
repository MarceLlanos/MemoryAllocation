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
        void SetSizePackage(int sizePackage);
        int GetId();
        void SetId(int idPackage);
        int DeleteId();
    }
}
