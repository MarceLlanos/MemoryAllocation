using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class ZeroingIdPackage : IZeroingIdPackage
    {
        public IPackage ZeroIdPackage(IBlock block, int idPackage)
        {
            IPackage result = null;

            foreach (var item in block.GetPackages())
            {
                if (item.GetId() == idPackage)
                {
                    item.DeleteId();
                    result = item;
                    break;
                }
            }
            return null;
        }
    }
}
