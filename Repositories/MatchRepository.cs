using HLTV.org.Constants;
using HLTV.org.Interfaces.Repositories;
using HLTV.org.Models;
using Newtonsoft.Json;

namespace HLTV.org.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly string dbPath = DbConstants.MATCHES_DB_PATH;
        public async Task<bool> CreateAsync(Match obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Match>>(json);
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
                var list = JsonConvert.DeserializeObject<List<Match>>(json);
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

        public async Task<List<Match>> GetAllAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Match>>(json);

                return list;
            }
            catch
            {
                return new List<Match>();
            }
        }

        public async Task<Match> GetAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Match>>(json);
                var item = list.FirstOrDefault(x => x.Id == id);
                return item;
            }
            catch
            {
                return new Match();
            }
        }

        public async Task<bool> UpdateAsync(int id, Match obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Match>>(json);
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
