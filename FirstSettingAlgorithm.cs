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
            IPackage result = new Package();
            foreach (var item in blocks)
            {
                foreach (var itemPackage in item.GetPackages())
                {
                    if (itemPackage.GetId() == 0 && itemPackage.GetSizePackage()>= package.GetSizePackage())
                    {
                        result = itemPackage;
                    }
                }
            }
            return result;
        }

        private int IsIdZero(List<IPackage> packages)
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
