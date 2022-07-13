using HLTV.org.Constants;
using HLTV.org.Interfaces.Repositories;
using HLTV.org.Models;
using Newtonsoft.Json;

namespace HLTV.org.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string dbPath = DbConstants.USERS_DB_PATH;
        public async Task<bool> CreateAsync(User obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<User>>(json);
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
                var list = JsonConvert.DeserializeObject<List<User>>(json);
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

        public async Task<List<User>> GetAllAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<User>>(json);

                return list;
            }
            catch
            {
                return new List<User>();
            }
        }

        public async Task<User> GetAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<User>>(json);
                var item = list.FirstOrDefault(x => x.Id == id);
                return item;
            }
            catch
            {
                return new User();
            }
        }

        public async Task<bool> UpdateAsync(int id, User obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<User>>(json);
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
