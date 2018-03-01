using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the matchup entries.
        /// </summary>
        public List<MatchupModel> Entries { get; set; } = new List<MatchupModel>();

        /// <summary>
        /// Represent the winner of the round.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the matchup rounds.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
