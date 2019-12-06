namespace MemoryBestAllocation
{
    interface IAllocateAlgorithmFactory
    {
        IPackage FindValidPackage(IBlock block, IPackage package);
    }
}