using HLTV.org.Interfaces.Repositories;
using HLTV.org.Models;
using HLTV.org.Repositories;

namespace HLTV.org.Pages.Coaches
{
    public class UpdatePage
    {
        public static async Task RunAsync()
        {
            Coach coach = new Coach();
            Console.Clear();

            Console.WriteLine("Id: /> ");
            coach.Id = int.Parse(Console.ReadLine());

            ICoachRepository coachRepository = new CoachRepository();
            var getCoachId = await coachRepository.GetAsync(coach.Id);

            if (getCoachId != null)
            {
                Console.WriteLine("------------ Update Counter Strike Coach ------------");

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

                await coachRepository.UpdateAsync(coach.Id, coach);

                Console.WriteLine("Successfully Updated!");
            }
            else
            {
                Console.WriteLine("Wrong Id! Try Again!");
                await RunAsync();
            }
        }
    }
}
