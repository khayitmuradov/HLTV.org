using HLTV.org.Interfaces.Repositories;
using HLTV.org.Interfaces.Services;
using HLTV.org.Repositories;
using HLTV.org.ViewModels;

namespace HLTV.org.Services
{
    internal class CoachService : ICoachService
    {
        private readonly CoachRepository coachRepository;
        private readonly ITeamRepository teamRepository;
        public CoachService()
        {
            coachRepository = new CoachRepository();
            teamRepository = new TeamRepository();
        }
        public async Task<IList<CoachViewModel>> GetAllAsync()
        {
            IList<CoachViewModel> listOfCoaches = new List<CoachViewModel>();
            var coaches = await coachRepository.GetAllAsync();
            foreach (var coach in coaches)
            {
                CoachViewModel coachViewModel = new CoachViewModel();
                coachViewModel.Id = coach.Id;
                coachViewModel.FirstName = coach.FirstName;
                coachViewModel.LastName = coach.LastName;
                coachViewModel.Country = coach.Country;
                coachViewModel.NickName = coach.NickName;
                coachViewModel.TeamName = (await teamRepository.GetAsync(coach.TeamId)).TeamName;
                listOfCoaches.Add(coachViewModel);
            }
            return listOfCoaches.OrderBy(x => x.Id).ToList();
        }
    }
}
