using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemoryFactory createMemory = new MemoryFactory();
            IMemoryFactory memoryFactory = new MemoryFactory();
            
            IOptionAlgorithm optionAlgorithm = new OptionAlgorithm();

            Console.WriteLine("Number of Memory blocks:");
            string numberBlocks = Console.ReadLine();
            Console.WriteLine("Size of Each Block:");
            string sizeBlocks = Console.ReadLine();
            Console.WriteLine("Choose one Algorithm:");
            Console.WriteLine("1 = First Allocation Memory");
            Console.WriteLine("2 = Best Allocation Memory");
            Console.WriteLine("3 = Worst Allocation Memory");
            string option = Console.ReadLine();

            var amount = int.Parse(numberBlocks);
            var size = int.Parse(sizeBlocks);
            var algorithmOption = optionAlgorithm.Option(int.Parse(option));

            memoryFactory.CreateMemory(amount, size, algorithmOption);

            
            
/*
            Console.WriteLine("ADD Package:");
            Console.WriteLine("DEL Package:");
            Console.WriteLine("SHOW");*/

            Console.ReadKey();
        }
    }
}
