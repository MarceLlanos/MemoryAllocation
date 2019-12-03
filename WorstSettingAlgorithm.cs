﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class WorstSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            var availablePackages = new PackagesAvailable().AvailablePackages(blocks, package);
            var maximunPackage = new MaximumMinimumPackage();

            if (availablePackages != null)
            {
                return maximunPackage.GetMaximunPackage(availablePackages);
            }

            return null;
        }
    }
}