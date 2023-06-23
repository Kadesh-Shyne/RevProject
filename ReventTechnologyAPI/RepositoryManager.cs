using ReventTechnologyAPI.Application;
using ReventTechnologyAPI.Data;

namespace ReventTechnologyAPI
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepoDbContext _repoDbContext;
        private readonly Lazy<IRevApiRepository> _revApi;
        public RepositoryManager (RepoDbContext repoDbContext)
        {
            _repoDbContext = repoDbContext;
            _revApi = new Lazy<IRevApiRepository>(() => new RevApiRepository(repoDbContext));
           
        }

        public IRevApiRepository revApi => throw new NotImplementedException();

        public async Task SaveAsync()
        {
         await _repoDbContext.SaveChangesAsync();
        }
    }
}
