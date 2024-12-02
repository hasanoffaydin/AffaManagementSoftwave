using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffaManagementSoftwave.Entity
{
    internal class ResultGame
    {
        private int id;
        private int gameId;
        private string team1Name;
        private string team2Name;
        private int team1Goals;
        private int team2Goals; 
        public int GameId { get { return gameId; } set { gameId = value; } }
        public int Id { get { return id; } set { id = value; } }
        public string Team1Name { get { return team1Name; } set { team1Name = value; } }
        public string Team2Name { get {return team2Name; } set {team2Name = value; } }
        public int Team1Goals { get { return team1Goals; } set { team1Goals = value; } }
        public int Team2Goals { get {return team2Goals; } set { team2Goals = value; } }
    }
}
