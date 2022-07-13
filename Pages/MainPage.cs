namespace HLTV.org.Pages
{
    public class MainPage
    {
        public static async Task RunPageAsync()
        {
            Console.WriteLine("1. Matches");
            Console.WriteLine("2. World Rankings");
            Console.WriteLine("3. Posts");
            Console.WriteLine("4. Teams");
            Console.WriteLine("5. Players");
            Console.WriteLine("6. Coaches");
            Console.WriteLine("7. Users");

            string input = Console.ReadLine();
            if (input == "5")
            {
                await PlayersPage.RunAsync();
            }
            else if (input == "6")
            {
                await CoachesPage.RunAsync();
            }
            else
            {
                await RunPageAsync();
                Console.WriteLine("Input is Wrong! Try Again!");
            }
            //if (Console.ReadLine() == "7")
            //{
            //    ConsoleTable consoleTable = new ConsoleTable("Id", "Email", "Nick Name", "Country",
            //                                                    "Fan Of (Player)", "Fan Of (Team)");
            //    IUserService userService = new UserService();
            //    var userViewModels = await userService.GetAllAsync();
            //    foreach (var userViewModel in userViewModels)
            //    {
            //        consoleTable.AddRow(userViewModel.Id,
            //            userViewModel.Email, userViewModel.NickName,
            //            userViewModel.Country, userViewModel.FanOfPlayer,
            //            userViewModel.FanOfTeam);
            //    }
            //    consoleTable.Write();
            //}
            //if (Console.ReadLine() == "4")
            //{
            //    ConsoleTable consoleTable = new ConsoleTable("Id", "Name", "Country", "World Ranking",
            //                                                    "Rifler", "AWPer", "Lurker", "Support",
            //                                                    "IGL", "Coach", "Earnings");
            //    ITeamService teamService = new TeamService();
            //    var teamViewModels = await teamService.GetAllAsync();
            //    foreach (var teamViewModel in teamViewModels)
            //    {
            //        consoleTable.AddRow(teamViewModel.Id,
            //            teamViewModel.Name, teamViewModel.Country,
            //            teamViewModel.WorldRanking, teamViewModel.Rifler,
            //            teamViewModel.AWPer, teamViewModel.Lurker,
            //            teamViewModel.Support, teamViewModel.IGL,
            //            teamViewModel.Coach, teamViewModel.Earnings);
            //    }
            //    consoleTable.Write();


        }
    }
}
