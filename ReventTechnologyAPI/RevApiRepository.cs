using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ReventTechnologyAPI.Application;
using ReventTechnologyAPI.Data;
using ReventTechnologyAPI.Models;
using System.ComponentModel;
using System.Linq;
using static ReventTechnologyAPI.DTOs.RevApiDto;

namespace ReventTechnologyAPI
{
    public class RevApiRepository : IRevApiRepository
    {
        private RepoDbContext _db;
        public RevApiRepository(RepoDbContext repoDbContext)
        {
            _db = repoDbContext;
        }
        public async Task<ViewRevApiDto> CreateRevApiAsync(CreateRevApiDto revApi)
        {
            RevApi newRevApi = new RevApi { Description = revApi.Description, Name = revApi.Name };
            _db.RevApis.Add(newRevApi);
            _db.SaveChanges();
            return new ViewRevApiDto(newRevApi.Id, newRevApi.Name, newRevApi.Description);
        }

        public async Task<ViewRevApiDto> DeleteRevApiAsync(int id)
        {

            _db.RevApis.RemoveRange();
            return null;


        }

        public async Task<IEnumerable<RevApi>> GetAllAsync(int id)
        {
          return await _db.RevApis.ToListAsync();
           // return await GetAllAsync(revApi);
        }

        public async Task<ViewRevApiDto> GetRevApiByIdAsync(int id)
        {
            var revApi = _db.RevApis.FirstOrDefault(x => x.Id == id);
            return new ViewRevApiDto(revApi.Id, revApi.Name, revApi.Description);
        }

        public async Task<ViewRevApiDto> UpdateRevApiAsync(CreateRevApiDto revApi)
        {
            RevApi newRevApi = new RevApi { Description = revApi.Description, Name = revApi.Name };
            _db.RevApis.Add(newRevApi);
            _db.SaveChanges();

            return new ViewRevApiDto(newRevApi.Id, newRevApi.Name, newRevApi.Description);
        }
    }
}
