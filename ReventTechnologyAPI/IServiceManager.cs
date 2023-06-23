using ReventTechnologyAPI.Application;

namespace ReventTechnologyAPI
{
    public interface IServiceManager
    {
        IRevApiRepository revApi { get; }
    }
}
