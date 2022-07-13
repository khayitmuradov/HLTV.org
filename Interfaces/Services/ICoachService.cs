using HLTV.org.ViewModels;

namespace HLTV.org.Interfaces.Services
{
    public interface ICoachService
    {
        Task<IList<CoachViewModel>> GetAllAsync();
    }
}
