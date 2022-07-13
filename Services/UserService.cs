using HLTV.org.Interfaces.Repositories;
using HLTV.org.Interfaces.Services;
using HLTV.org.Repositories;
using HLTV.org.ViewModels;

namespace HLTV.org.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IPlayerRepository playerRepository;
        private readonly ITeamRepository teamRepository;

        public UserService()
        {
            userRepository = new UserRepository();
            playerRepository = new PlayerRepository();
            teamRepository = new TeamRepository();
        }

        public async Task<IList<UserViewModel>> GetAllAsync()
        {
            IList<UserViewModel> listOfUsers = new List<UserViewModel>();
            var users = await userRepository.GetAllAsync();
            foreach (var user in users)
            {
                UserViewModel userViewModel = new UserViewModel();
                userViewModel.Id = user.Id;
                userViewModel.Email = user.Email;
                userViewModel.NickName = user.NickName;
                userViewModel.Country = user.Country;
                userViewModel.FanOfPlayer = (await playerRepository.GetAsync(user.PlayerId)).NickName;
                userViewModel.FanOfTeam = (await teamRepository.GetAsync(user.TeamId)).TeamName;
                listOfUsers.Add(userViewModel);
            }
            return listOfUsers.OrderBy(x => x.Id).ToList();

        }
    }
}
