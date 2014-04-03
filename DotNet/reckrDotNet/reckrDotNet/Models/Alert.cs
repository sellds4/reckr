using System.Collections.Generic;

namespace reckrDotNet.Models
{
    public class Alert
    {
        public int AlertID { get; set; }
        public string Text { get; set; }

        public ICollection<Player> AlertPlayers { get; set; }
    }
}