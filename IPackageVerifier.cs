﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IPackageVerifier
    {
        IPackage CreatePackageVerified(List<IPackage> packages);
    }
}
