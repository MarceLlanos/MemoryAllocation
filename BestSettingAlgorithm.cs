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
            IPackage result = new Package();
            foreach (var item in blocks)
            {
                if (GetMinorPackage(item.GetPackages()).GetSizePackage() >= package.GetSizePackage())
                {
                    result = GetMinorPackage(item.GetPackages());
                }
            }
            return result;
        }

        private IPackage GetMinorPackage(List<IPackage> lista)
        {
            IPackage result = new Package();

            for (int i = 0; i < lista.Count; i++)
            {
                result = lista[i].GetSizePackage() <= lista[i + 1].GetSizePackage()? lista[i]: lista[i+1];
            }
            return result;
        }
    }
}
