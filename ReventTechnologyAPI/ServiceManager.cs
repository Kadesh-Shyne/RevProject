using ReventTechnologyAPI.Application;
using ReventTechnologyAPI.Models;

namespace ReventTechnologyAPI
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IRevApiRepository> _revApi;

        //public ServiceManager(IRepositoryManager repositoryManager, ILogger logger)
        //{
        //    _revApi = new Lazy<IRevApi>(() => new RevApi(repositoryManager));
        //}
        public IRevApiRepository revApi => _revApi.Value; 
       
    }
}
