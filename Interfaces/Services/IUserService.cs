using HLTV.org.ViewModels;

namespace HLTV.org.Interfaces.Services
{
    public interface IUserService
    {
        Task<IList<UserViewModel>> GetAllAsync();
    }
}
