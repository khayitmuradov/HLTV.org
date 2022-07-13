using ConsoleTables;
using HLTV.org.Interfaces.Repositories;
using HLTV.org.Repositories;

namespace HLTV.org.Pages.Coaches
{
    public class ReadPage
    {
        public static async Task RunAsync()
        {
            Console.Write("Coach Id: /> ");
            int searchCoach = int.Parse(Console.ReadLine());

            ConsoleTable consoleTable = new ConsoleTable("Id", "First Name", "Last Name",
                                            "Country", "Nick Name", "Team");
            ICoachRepository coachRepository = new CoachRepository();

            var coach = await coachRepository.GetAsync(searchCoach);

            if (coach != null)
            {
                consoleTable.AddRow(coach.Id,
                    coach.FirstName, coach.LastName,
                    coach.Country, coach.NickName,
                    coach.TeamId);

                consoleTable.Write();
            }
            else
            {
                Console.WriteLine("Wrong Id! Try Again!");
                await RunAsync();
            }
        }
    }
}
