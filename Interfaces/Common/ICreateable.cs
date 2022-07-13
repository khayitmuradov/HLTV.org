namespace HLTV.org.Interfaces.Common
{
    public interface ICreateable<T>
    {
        Task<bool> CreateAsync(T obj);
    }
}
