namespace Zelda.Repositories
{
    public class ZeldaRepositoryBase<T,K> : RepositoryBase<T, K, ZeldaContext> where T : class
    {
        public ZeldaRepositoryBase(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
