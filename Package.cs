using System;
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

        public void SetId(int idPackage)
        {
            this.idPackage = idPackage;
        }

        public void SetSizePackage(int sizePackage)
        {
            this.sizePackage = sizePackage;
        }
    }
}
