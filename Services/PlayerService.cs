using HLTV.org.Interfaces.Repositories;
using HLTV.org.Interfaces.Services;
using HLTV.org.Repositories;
using HLTV.org.ViewModels;

namespace HLTV.org.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly PlayerRepository playerRepository;
        private readonly ITeamRepository teamRepository;
        public PlayerService()
        {
            playerRepository = new PlayerRepository();
            teamRepository = new TeamRepository();
        }
        public async Task<IList<PlayerViewModel>> GetAllAsync()
        {
            IList<PlayerViewModel> listOfPlayers = new List<PlayerViewModel>();
            var players = await playerRepository.GetAllAsync();
            foreach (var player in players)
            {
                PlayerViewModel playerViewModel = new PlayerViewModel();
                playerViewModel.Id = player.Id;
                playerViewModel.FirstName = player.FirstName;
                playerViewModel.LastName = player.LastName;
                playerViewModel.Country = player.Country;
                playerViewModel.NickName = player.NickName;
                playerViewModel.TeamName = (await teamRepository.GetAsync(player.TeamId)).TeamName;
                playerViewModel.PlayerRank = player.WorldRanking;
                listOfPlayers.Add(playerViewModel);
            }
            return listOfPlayers.OrderBy(x => x.PlayerRank).ToList();
        }
    }
}
