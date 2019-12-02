﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class Package : IPackage
    {
        int sizePackage;
        int idPackage;
        public Package()
        {
        }

        public int DeleteId()
        {
            return idPackage -= idPackage;
        }

        public int GetId()
        {
            return idPackage;
        }

        public int GetSizePackage()
        {
            return sizePackage;
        }
    }
}
