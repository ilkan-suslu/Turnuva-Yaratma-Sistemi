using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }

        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represent one team in the Matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public double Score { get; set; }

        public int parentMatchupId { get; set; }
        /// <summary>
        /// Represent the matchup that this team came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
