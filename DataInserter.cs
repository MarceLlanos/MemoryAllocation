using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class DataInserter : IDataInserter
    {
        int index;
        int sizeResult;
        public DataInserter(int index, int sizeResult)
        {
            this.index = index;
            this.sizeResult = sizeResult;
        }

        public int GetIndex()
        {
            return index;
        }

        public int GetSizeResult()
        {
            return sizeResult;
        }
    }
}
