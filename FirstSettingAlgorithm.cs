using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class FirstSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        IVerifier verifier;

        public FirstSettingAlgorithm(IVerifier verifier)
        {
            this.verifier = verifier;
        }

        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            foreach (var item in blocks)
            {
                foreach (var itemPackage in item.GetPackages())
                {
                    if (verifier.VerifyPackages(itemPackage, package))
                    {
                        return itemPackage;
                    }
                }
            }

            return null;
        }        
    }
}