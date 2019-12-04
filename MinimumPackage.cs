using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class MinimumPackage : IMinimumMaximunPackage
    {
        IPackage firstPackage;
        IPackage secondPackage;

        public MinimumPackage(IPackage firstPackage, IPackage secondPackage)
        {
            this.firstPackage = firstPackage;
            this.secondPackage = secondPackage;
        }

        public IPackage GetPackage()
        {
            if (firstPackage.GetSizePackage() <= secondPackage.GetSizePackage())
            {
                secondPackage = firstPackage;
            }
            return secondPackage;
        }
    }
}
