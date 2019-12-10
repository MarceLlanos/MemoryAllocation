using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class VacatePackages : IVacatePackages
    {
        IVerifier verifyPackage = new VerifierVacatePackage();
        List<IPackage> packages = new List<IPackage>();
           
        public List<IPackage> VacatedPackages(IBlock[] blocks, IPackage package)
        {
            foreach (var item in blocks)
            {
                if (item.GetPackages() == null || item.GetPackages().Count == 0)
                {
                    return null;
                }

                var result = new List<IPackage>();

                foreach (var itemPackage in item.GetPackages())
                {
                    if (verifyPackage.VerifyPackages(itemPackage, package))
                    {
                        packages.Add(itemPackage);
                    }
                }
            }
            
            return packages;
            
        }

    }
}
