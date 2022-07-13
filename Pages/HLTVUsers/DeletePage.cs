using ConsoleTables;
using HLTV.org.Interfaces.Services;
using HLTV.org.Repositories;
using HLTV.org.Services;

namespace HLTV.org.Pages.Coaches
{
    public class DeletePage
    {
        public static async Task RunAsync()
        {
            ConsoleTable consoleTable = new ConsoleTable("Id", "First Name", "Last Name",
                                                "Country", "Nick Name", "Team");
            ICoachService coachService = new CoachService();
            CoachRepository coachRepository = new CoachRepository();
            var coachViewModels = await coachService.GetAllAsync();
            foreach (var coachViewModel in coachViewModels)
            {
                consoleTable.AddRow(coachViewModel.Id,
                    coachViewModel.FirstName, coachViewModel.LastName,
                    coachViewModel.Country, coachViewModel.NickName,
                    coachViewModel.TeamName);
            }
            consoleTable.Write();

            Console.WriteLine("Input an Id of a Coach to Delete");
            int deleteId = int.Parse(Console.ReadLine());

            bool isCorrect = (coachViewModels.FirstOrDefault(x => x.Id == deleteId) != null);

            if (isCorrect)
            {
                await coachRepository.DeleteAsync(deleteId);
                Console.WriteLine("Successfully Done!");
            }
            else
            {
                Console.WriteLine("Wrong Id! Try Again");
                await RunAsync();
            }
        }
    }
}
