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
            List<IPackage> packagesIdZero = new List<IPackage>();

            foreach (var item in blocks)
            {
                foreach (var itemPackage in item.GetPackages())
                {
                    
                    if(itemPackage.GetId() == 0 && itemPackage.GetSizePackage() >= package.GetSizePackage())
                    {
                        packagesIdZero.Add(itemPackage);
                    } 
                }
            }

            
            

            if (packagesIdZero.Count == 0)
            {
                return null;
            }
            if(packagesIdZero.Count == 1)
            {
                return packagesIdZero[0];
            }

            var packageMinSize = packagesIdZero[0];

            foreach (var item in packagesIdZero)
            {
                if (item.GetSizePackage() <= packageMinSize.GetSizePackage())
                {
                    packageMinSize = item;
                }

            }

            return packageMinSize;
        }

        private IPackage VerifyPackages(List<IPackage> packages, int compare)
        {
            if (packages.Count == 1)
            {
                return packages[0];
            }
            else
            {
                return null;
            }
        }
    }
}