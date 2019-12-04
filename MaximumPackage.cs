using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class MaximumPackage : IMinimumMaximunPackage
    {
        IPackage firstPackage;
        IPackage secondPackage;
        public MaximumPackage(IPackage firstPackage, IPackage secondPackage)
        {
            this.firstPackage = firstPackage;
            this.secondPackage = secondPackage;
        }

        public IPackage GetPackage()
        {
            if (firstPackage.GetSizePackage() > secondPackage.GetSizePackage())
            {
                secondPackage = firstPackage;
            }
            return secondPackage;
        }
    }
}
