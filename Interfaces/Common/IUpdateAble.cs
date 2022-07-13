namespace HLTV.org.Interfaces.Common
{
    public interface IUpdateAble<T>
    {
        Task<bool> UpdateAsync(int id, T obj);
    }
}
