using HLTV.org.Pages;

namespace HLTV.org
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await MainPage.RunPageAsync();
            //ICoachRepository coachRepository = new CoachRepository();
            //Coach coach = new Coach()
            //{
            //    Id = 1,
            //    FirstName = "Rémy",
            //    LastName = "Quoniam",
            //    Country = "France",
            //    NickName = "XTQZZZ",
            //    TeamId = 1
            //};

            //await coachRepository.CreateAsync(coach);

            //IMatchRepository matchRepository = new MatchRepository();
            //Match match = new Match()
            //{
            //    Id = 2,
            //    MatchName = "Team Liquid vs Heroic",
            //    MatchDate = "12122022",
            //    MatchDuration = "Ongoing"
            //};
            //await matchRepository.CreateAsync(match);


            //IPlayerRepository playerRepository = new PlayerRepository();
            //Player player = new Player()
            //{
            //    Id = 8,
            //    FirstName = "Audrig",
            //    LastName = "Jug",
            //    NickName = "Jackz",
            //    Password = "Audrig",
            //    Country = "France",
            //    PlayerType = Enums.PlayerType.Support,
            //    TeamId = 1,
            //    WorldRanking = 56
            //};
            //await playerRepository.CreateAsync(player);

            //IPostRepository postRepository = new PostRepository();
            //Post post = new Post()
            //{
            //    Id = 1,
            //    PostTitle = "What happened to s1mple?",
            //    PostText = "In the last 3 months s1mple can't do something really cool. Cuz he is dumb",
            //    UserId = 1
            //};
            //await postRepository.CreateAsync(post);

            //ITeamRepository teamRepository = new TeamRepository();
            //Team team = new Team()
            //{
            //    Id = 1,
            //    TeamName = "Natus Vincere",
            //    WorldRanking = 1,
            //    RiflerId = 5,
            //    AWPerId = 2,
            //    LurkerId = 6,
            //    SupportId = 9,
            //    IGLId = 7,
            //    CoachId = 2,
            //    Country = "Ukraine",
            //    Earnings = "2 major 10 mvp"
            //};
            //await teamRepository.UpdateAsync(2, team);

            //IUserRepository userRepository = new UserRepository();
            //User user = new User()
            //{
            //    Id = 2,
            //    Email = "dodosh@gmail.com",
            //    NickName = "d0d0sh",
            //    Password = "d0doshjon@325(*",
            //    Country = "Italy",
            //    PlayerId = 2,
            //    TeamId = 1
            //};
            //await userRepository.UpdateAsync(3, user);

        }
    }
}