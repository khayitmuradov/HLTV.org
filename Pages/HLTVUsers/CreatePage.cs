using HLTV.org.Interfaces.Repositories;
using HLTV.org.Models;
using HLTV.org.Repositories;

namespace HLTV.org.Pages.HLTVUsers
{
    public class CreatePage
    {
        public static async Task RunAsync()
        {
            Coach coach = new Coach();
            Console.Clear();
            Console.WriteLine("------------ New Counter Strike Coach ------------");
            Console.WriteLine("Id: /> ");
            coach.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("First Name: />");
            coach.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name: />");
            coach.LastName = Console.ReadLine();

            Console.WriteLine("Country: />");
            coach.Country = Console.ReadLine();

            Console.WriteLine("Nick Name: />");
            coach.NickName = Console.ReadLine();

            Console.WriteLine("Team Id: />");
            coach.TeamId = int.Parse(Console.ReadLine());

            ICoachRepository coachRepository = new CoachRepository();
            await coachRepository.CreateAsync(coach);

            Console.WriteLine("Successfully Done!");
        }
    }
}
