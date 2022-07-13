using ConsoleTables;
using HLTV.org.Interfaces.Services;
using HLTV.org.Services;

namespace HLTV.org.Pages.Coaches
{
    public class ReadAllPage
    {
        public static async Task RunAsync()
        {
            ConsoleTable consoleTable = new ConsoleTable("Id", "First Name", "Last Name",
                                                "Country", "Nick Name", "Team");
            ICoachService coachService = new CoachService();

            var coachViewModels = await coachService.GetAllAsync();
            foreach (var coachViewModel in coachViewModels)
            {
                consoleTable.AddRow(coachViewModel.Id,
                    coachViewModel.FirstName, coachViewModel.LastName,
                    coachViewModel.Country, coachViewModel.NickName,
                    coachViewModel.TeamName);
            }
            consoleTable.Write();
        }
    }
}
