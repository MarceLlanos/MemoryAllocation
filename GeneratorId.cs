using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class GeneratorId : IGeneratorId
    {
        public int GenerateId()
        {
            int result = 0;
            string idGenerate = string.Empty;

            if (idGenerate.Length == 0)
            {
                result += 1;
                idGenerate += result;
            }
            if (idGenerate.Length > 0)
            {
                result = idGenerate.Length + 1;
                idGenerate += result;
            }

            return result;
        }
    }
}
