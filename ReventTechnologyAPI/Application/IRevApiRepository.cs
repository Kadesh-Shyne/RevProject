using ReventTechnologyAPI.Models;
using static ReventTechnologyAPI.DTOs.RevApiDto;

namespace ReventTechnologyAPI.Application
{
    public interface IRevApiRepository
    {
        Task<IEnumerable<RevApi>> GetAllAsync(int id);
        Task<ViewRevApiDto> GetRevApiByIdAsync(int id);
        Task<ViewRevApiDto> DeleteRevApiAsync(int id);
        Task<ViewRevApiDto> CreateRevApiAsync(CreateRevApiDto revApi);
        Task<ViewRevApiDto> UpdateRevApiAsync(CreateRevApiDto revApi);
       
    }
}
