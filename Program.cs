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
            bool follow = true;

            IMemoryFactory createMemory = new MemoryFactory();
            IMemoryFactory memoryFactory = new MemoryFactory();
            IOptionAlgorithm optionAlgorithm = new OptionAlgorithm();
            IPackageFactory packageFactory = new PackageFactory(new GeneratorId());


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
            var memory = memoryFactory.CreateMemory(amount, size, algorithmOption);

            while (follow)
            {
                Console.WriteLine("ADD");
                Console.WriteLine("DEL");
                Console.WriteLine("SHOW");
                Console.WriteLine("ESC");

                string addPackage = Console.ReadLine();

                if (addPackage == "ADD" || addPackage == "add")
                {
                    Console.WriteLine("Size of Package:");
                    string sizePackage = Console.ReadLine();

                    if (memory.AddPackageToMemory(packageFactory.CreatePackage(int.Parse(sizePackage), null)))
                    {
                        Console.WriteLine("Added Correctly!");

                    }
                    else
                    {
                        Console.WriteLine("It doesn't Added");
                    }
                }

                if (addPackage == "DEL" || addPackage == "del")
                {
                    Console.WriteLine("Id Package:");
                    string idPackage = Console.ReadLine();
                    var package = memory.DeleteById(int.Parse(idPackage));

                    if (package != null)
                    {
                        Console.WriteLine("Deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Not found!");
                    }
                }

                if (addPackage == "SHOW" || addPackage == "SHOW")
                {
                    memory.showMemory();
                }

                if (addPackage == "ESC" || addPackage == "esc")
                {
                    follow = false;
                }
            }

            Console.ReadKey();
        }
    }
}
