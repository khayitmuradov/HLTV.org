using HLTV.org.ViewModels;

namespace HLTV.org.Interfaces.Services
{
    public interface ITeamService
    {
        Task<IList<TeamViewModel>> GetAllAsync();
    }
}
