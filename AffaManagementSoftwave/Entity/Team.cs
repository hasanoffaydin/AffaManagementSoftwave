using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AffaManagementSoftwave.Entity
{
    internal class Team
    {
        private int id;
        private string teamName;
        private int teamScore;
        public int Id { get { return id; } set { id = value; } }
        public string TeamName { get { return teamName; } set { teamName = value; } }
        public int TeamScore { get { return teamScore; } set { teamScore = value; } }
    }
}
