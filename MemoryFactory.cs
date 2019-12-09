using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class MemoryFactory : IMemoryFactory
    {
        public IMemory CreateMemory(int blocksNumber, int sizeBlock, string algorithm)
        {
            IAllocationAlgorithmFactory allocationAlgorithm = new AllocationAlgorithmFactory();
            IBlock[] blocks = new BlockFactory().createBlocks(blocksNumber, sizeBlock);
            IPackageFactory packageFactory = new PackageFactory(new GeneratorId());


            var algorithmInstance = allocationAlgorithm.CreateAllocationAlgorithm(algorithm);

            IMemory memory = new Memory(blocks, algorithmInstance);
            memory.showMemory();

            Console.WriteLine("ADD");
            Console.WriteLine("DEL");
            Console.WriteLine("SHOW");

            string addPackage = Console.ReadLine();

            if (addPackage == "ADD")
            {
                foreach (var item in blocks)
                {
                    Console.WriteLine("Size of Package:");
                    string sizePackage = Console.ReadLine();
                    if (memory.AddPackageToMemory(packageFactory.CreatePackage(int.Parse(sizePackage), item)))
                    {
                        Console.WriteLine("Added Correctly!");
                    }
                    else
                    {
                        Console.WriteLine("It doesn't Added");
                    }
                }
            }

            if (addPackage == "DEL")
            {
                Console.WriteLine("Id Package:");
                string idPackage = Console.ReadLine();
                memory.DeleteById(int.Parse(idPackage));
            }

            if (addPackage == "show")
            {
            }

            return memory;
        }
    }
}
