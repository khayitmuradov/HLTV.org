using HLTV.org.Constants;
using HLTV.org.Interfaces.Repositories;
using HLTV.org.Models;
using Newtonsoft.Json;

namespace HLTV.org.Repositories
{
    public class CoachRepository : ICoachRepository
    {
        private readonly string dbPath = DbConstants.COACHES_DB_PATH;
        public async Task<bool> CreateAsync(Coach obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Coach>>(json);
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
                var list = JsonConvert.DeserializeObject<List<Coach>>(json);
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

        public async Task<List<Coach>> GetAllAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Coach>>(json);

                return list;
            }
            catch
            {
                return new List<Coach>();
            }
        }

        public async Task<Coach> GetAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Coach>>(json);
                var item = list.FirstOrDefault(x => x.Id == id);
                return item;
            }
            catch
            {
                return new Coach();
            }
        }

        public async Task<bool> UpdateAsync(int id, Coach obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Coach>>(json);
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
