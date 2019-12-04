using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BestSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        public BestSettingAlgorithm()
        {

        }
        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            var availablePackages = new AvailablePacks().GetAvailablePackages(blocks, package);
            var minimumPackage = new MaxMinPackage();

            if (availablePackages != null)
            {
                return minimumPackage.GetMinimunPackage(availablePackages);
            }

            return null;
        } 
        

    }
}
