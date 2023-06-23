using ReventTechnologyAPI.Application;

namespace ReventTechnologyAPI
{
    public interface IRepositoryManager
    {
        IRevApiRepository revApi { get; }
        Task SaveAsync();
    }
}
