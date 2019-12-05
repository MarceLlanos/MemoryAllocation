using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class ValidatePackagesFactory : IValidatePackagesFactory
    {
        IVerifier availablePackage = new VerifierPackageAvailable();
           
        public List<IPackage> CreateValidPackages(IBlock block, IPackage package)
        {
            if (block.GetPackages() == null || block.GetPackages().Count == 0)
            {
                return null;
            }

            var result = new List<IPackage>();

            foreach (var itemPackage in block.GetPackages())
            {
                if (availablePackage.VerifyPackages(itemPackage, package))
                {
                    result.Add(itemPackage);
                }
            }

            return result;
            
        }

    }
}
