using System.Collections.Generic;

namespace reckrDotNet.Models
{
    public class Court
    {
        public int CourtID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Coordinates Coordinates { get; set;}
        public int NumberOfCourts { get; set; }
        public string CourtType { get; set; }
        public PlayerRating AvgPlayerRating { get; set; }
        public int NumberOfPlayers { get; set; }
    }
}