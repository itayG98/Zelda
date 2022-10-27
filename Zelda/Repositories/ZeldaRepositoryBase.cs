namespace Zelda.Repositories
{/// <summary>
/// This abstract class implement generic Repository with the ZeldaContext
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="K"></typeparam>
    public abstract class ZeldaRepositoryBase<T,K> : RepositoryBase<T, K, ZeldaContext> where T : class
    {
        public ZeldaRepositoryBase(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
