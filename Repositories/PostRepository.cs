using HLTV.org.Constants;
using HLTV.org.Interfaces.Repositories;
using HLTV.org.Models;
using Newtonsoft.Json;

namespace HLTV.org.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly string dbPath = DbConstants.POSTS_DB_PATH;
        public async Task<bool> CreateAsync(Post obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Post>>(json);
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
                var list = JsonConvert.DeserializeObject<List<Post>>(json);
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

        public async Task<List<Post>> GetAllAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Post>>(json);

                return list;
            }
            catch
            {
                return new List<Post>();
            }
        }

        public async Task<Post> GetAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Post>>(json);
                var item = list.FirstOrDefault(x => x.Id == id);
                return item;
            }
            catch
            {
                return new Post();
            }
        }

        public async Task<bool> UpdateAsync(int id, Post obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(dbPath);
                var list = JsonConvert.DeserializeObject<List<Post>>(json);
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
