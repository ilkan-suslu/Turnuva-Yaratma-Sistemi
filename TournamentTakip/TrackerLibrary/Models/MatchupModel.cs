using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {


        public int Id { get; set; }
        /// <summary>
        /// Represents the 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represent the Id of winner of the matchup (For database to call the winner)
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// Represent the winner of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents number of the round of matchup
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";

                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        }
                    }
                    else
                    {
                        output = "Match Not Yet Determined";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
