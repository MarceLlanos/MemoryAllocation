using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class GeneratorId : IGeneratorId
    {
        int ids;

        public GeneratorId()
        {
            ids = 0;
        }
        public int GenerateId()
        {
            ids  += 1;
            return ids;
        }
    }
}
