namespace sim756.Piranha.PiranhaSearch
{
    public class SearchThreadingConfiguration
    {
        /// <summary>
        /// Number of maximum Threads, will be spawned and pushed to the pool. Set 0 (Zero) to let .NET manage the limit. Default: 1024
        /// </summary>
        public int MaximumSpawnedThread { get; set; } = 1024;

        /// <summary>
        /// 
        /// </summary>
        public int MaximumPrimaryMemoryForResult { get; set; } = 1024;
    }
}