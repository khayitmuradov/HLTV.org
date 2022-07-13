namespace HLTV.org.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public int TeamId { get; set; }
        public int WorldRanking { get; set; }

    }
}
