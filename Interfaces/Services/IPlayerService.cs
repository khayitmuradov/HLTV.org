using HLTV.org.ViewModels;

namespace HLTV.org.Interfaces.Services
{
    public interface IPlayerService
    {
        Task<IList<PlayerViewModel>> GetAllAsync();
    }
}
