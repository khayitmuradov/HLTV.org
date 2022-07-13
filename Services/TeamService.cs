using HLTV.org.Interfaces.Repositories;
using HLTV.org.Interfaces.Services;
using HLTV.org.Repositories;
using HLTV.org.ViewModels;

namespace HLTV.org.Services
{
    public class TeamService : ITeamService
    {
        private readonly TeamRepository teamRepository;
        private readonly IPlayerRepository playerRepository;
        private readonly ICoachRepository coachRepository;

        public TeamService()
        {
            teamRepository = new TeamRepository();
            playerRepository = new PlayerRepository();
            coachRepository = new CoachRepository();
        }
        public async Task<IList<TeamViewModel>> GetAllAsync()
        {
            IList<TeamViewModel> listOfTeams = new List<TeamViewModel>();
            var teams = await teamRepository.GetAllAsync();
            foreach (var team in teams)
            {
                TeamViewModel teamViewModel = new TeamViewModel();
                teamViewModel.Id = team.Id;
                teamViewModel.Name = team.TeamName;
                teamViewModel.Country = team.Country;
                teamViewModel.Rifler = (await playerRepository.GetAsync(team.RiflerId)).NickName;
                teamViewModel.AWPer = (await playerRepository.GetAsync(team.AWPerId)).NickName;
                teamViewModel.Lurker = (await playerRepository.GetAsync(team.LurkerId)).NickName;
                teamViewModel.Support = (await playerRepository.GetAsync(team.SupportId)).NickName;
                teamViewModel.IGL = (await playerRepository.GetAsync(team.IGLId)).NickName;
                teamViewModel.Coach = (await playerRepository.GetAsync(team.CoachId)).NickName;
                teamViewModel.WorldRanking = team.WorldRanking;
                teamViewModel.Earnings = team.Earnings;
                listOfTeams.Add(teamViewModel);
            }
            return listOfTeams.OrderBy(x => x.WorldRanking).ToList();
        }
    }
}
