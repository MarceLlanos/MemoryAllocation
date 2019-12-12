﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class WorstAlgorithmFactory : IAllocateAlgorithmFactory
    {
        IAllocationMemoryAlgorithm worstAllocation;
        IVerifier maxVerifier;
        IPackageVerifier packageVerifier;

        
        public IAllocationMemoryAlgorithm CreateAllocationPackageAlgorithm()
        {
            maxVerifier = new VerifierMaxPackage();
            packageVerifier = new PackageVerifier(maxVerifier, new VerifierVacatePackage());
            worstAllocation = new AllocationAlgorithmSetting(maxVerifier, packageVerifier);

            return worstAllocation;
        }
    }
}