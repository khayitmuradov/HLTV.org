namespace HLTV.org.Interfaces.Common
{
    public interface IDeleteable<T>
    {
        Task<bool> DeleteAsync(int id);
    }
}
