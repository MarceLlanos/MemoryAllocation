﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class CreatorAlgorithm : ICreatorAlgorithm
    {
        public IAllocationMemoryAlgorithm CreateAlgorithm(string algorithmOption)
        {
            switch (algorithmOption)
            {
                case "First Setting Allocation":
                    return new FirstSettingAlgorithm();
                case "Best Setting Allocation":
                    return new BestSettingAlgorithm();
                case "Wrost Setting Allocation":
                    return new WorstSettingAlgorithm();
                default:
                    return new FirstSettingAlgorithm();
            }
        }
    }
}
