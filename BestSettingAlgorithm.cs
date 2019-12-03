using System;
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
            /*List<IPackage> packagesIdZero = new List<IPackage>();*/

            var availablePackages = AvailablePackages(blocks, package);

            if (availablePackages != null)
            {
                return MinimunPackage(availablePackages);
            }
            return null;

            /*foreach (var item in blocks)
            {
                if (AvailablePackages(item.GetPackages(), package) != null)
                {

                }

                foreach (var itemPackage in item.GetPackages())
                {
                    if (itemPackage.GetId() == 0 && itemPackage.GetSizePackage() >= package.GetSizePackage())
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

            return packageMinSize;*/
        }

        /*private IPackage VerifyPackages(List<IPackage> packages, int compare)
        {
            if (packages.Count == 1)
            {
                return packages[0];
            }
            else
            {
                return null;
            }
        }*/

        private List<IPackage> AvailablePackages(IBlock[] block, IPackage package)
        {
            List<IPackage> packagesAvailable = null;

            foreach (var item1 in block)
            {
                foreach (var item in item1.GetPackages())
                {
                    if (item.GetId() == 0 && item.GetSizePackage() >= package.GetSizePackage())
                    {
                        packagesAvailable.Add(item);
                    }
                }
            }            

            return packagesAvailable;
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
