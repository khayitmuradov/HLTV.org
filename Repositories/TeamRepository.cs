using HLTV.org.Constants;
using HLTV.org.Interfaces.Repositories;
using HLTV.org.Models;
using Newtonsoft.Json;

namespace HLTV.org.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly string dbPath = DbConstants.TEAMS_DB_PATH;
        public async Task<bool> CreateAsync(Team obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Team>>(json);
                list.Add(obj);
                json = JsonConvert.SerializeObject(list);
                await File.WriteAllTextAsync(dbPath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Team>>(json);
                var item = list.FirstOrDefault(x => x.Id == id);
                list.Remove(item);
                json = JsonConvert.SerializeObject(list);
                await File.WriteAllTextAsync(dbPath, json);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Team>> GetAllAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Team>>(json);

                return list;
            }
            catch
            {
                return new List<Team>();
            }
        }

        public async Task<Team> GetAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Team>>(json);
                var item = list.FirstOrDefault(x => x.Id == id);
                return item;
            }
            catch
            {
                return new Team();
            }
        }

        public async Task<bool> UpdateAsync(int id, Team obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Team>>(json);
                var index = list.TakeWhile(x => x.Id != id).Count();
                list[index] = obj;
                json = JsonConvert.SerializeObject(list);
                await File.WriteAllTextAsync(dbPath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
