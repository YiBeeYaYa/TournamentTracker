using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary {
    class TournamentModel {
        public string TournamentName { get; set; }
        public decimal Entryfee { get; set; }
        public List<TeamModel> EnteerTeam { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prize { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
