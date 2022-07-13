namespace HLTV.org.Interfaces.Common
{
    public interface IReadable<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
    }
}
