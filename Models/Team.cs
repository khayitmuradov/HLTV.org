namespace HLTV.org.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int WorldRanking { get; set; }
        public string Country { get; set; }
        public int RiflerId { get; set; }
        public int AWPerId { get; set; }
        public int LurkerId { get; set; }
        public int SupportId { get; set; }
        public int IGLId { get; set; }
        public int CoachId { get; set; }
        public string Earnings { get; set; }

    }
}
