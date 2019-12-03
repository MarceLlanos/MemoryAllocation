using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class FirstSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        

        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            foreach (var item in blocks)
            {
                if (IsIdZero(item.GetPackages()) == 0 && SizePackage(item.GetPackages()) >= package.GetSizePackage())
                {
                    
                }
            }
           
        }

        public int IsIdZero(List<IPackage> packages)
        {
            var result = 0;
            foreach (var item in packages)
            {
                result = item.GetId() == 0 ? result : result = 1;
            }
            return result;
        }

        public int SizePackage(List<IPackage> packages)
        {
            var result = 0;
            foreach (var item in packages)
            {
                result = item.GetSizePackage();
            }
            return result;
        }
    }
}
