using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AffaManagementSoftwave.Entity
{
    internal class Games
    {
        
        private int id;
        private int homeTeamId;
        private int awayTeamId;
        private DateTime gameDate;
        private int homeTeamScore;
        private int awayTeamScore;

        public int Id { get { return id; } set { id = value; } }
        public int HomeTeamId { get { return homeTeamId; } set { homeTeamId = value; } }
        public int AwayTeamId { get {return awayTeamId; } set {awayTeamId = value; } }
        public DateTime GameDate { get { return gameDate; } set { gameDate = value; } }
        public int HomeTeamScore { get { return homeTeamScore; } set {homeTeamScore = value; } }
        public int AwayTeamScore { get {return awayTeamScore; } set {  awayTeamScore = value; } }
    }
}
