using System.Collections.Generic;

namespace reckrDotNet.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public PlayerRating PlayerRating { get; set; }

        public virtual ICollection<Court> HomeCourts { get; set; }
        public virtual ICollection<Player> PlayersFollowed { get; set; }
        public virtual ICollection<Alert> PlayerAlerts { get; set; }
    }
}