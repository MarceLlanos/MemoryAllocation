﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class AvailablePackagesFactory : IAvailablePackagesFactory
    {
        IBlock block;
        List<IPackage> packages;

        public AvailablePackagesFactory(IBlock block, List<IPackage> packages)
        {
            this.block = block;
            this.packages = packages;
        }

        public void AddPackagesToAvailablePackages(IPackage package)
        {
            foreach (var item in block.GetPackages())
            {
                if (item.GetId() == 0 && item.GetSizePackage() >= package.GetSizePackage())
                {
                    packages.Add(item);
                }
            }
        }

    }
}