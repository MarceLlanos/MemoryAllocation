﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BestSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            var availablePackages = new PackagesAvailable().AvailablePackages(blocks, package);

            if (availablePackages != null)
            {
                return MinimunPackage(availablePackages);
            }

            return null;
        }        

        private IPackage MinimunPackage(List<IPackage> packages)
        {
            var packageMinSize = packages[0];

            foreach (var item in packages)
            {
                if (item.GetSizePackage() <= packageMinSize.GetSizePackage())
                {
                    packageMinSize = item;
                }

            }

            return packageMinSize;
        }
    }
}
