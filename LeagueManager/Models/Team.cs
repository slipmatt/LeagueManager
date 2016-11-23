using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManager.Models
{
    [DataContract]
    public class Team
    {
        [DataMember]
        public int TeamId { get; set; }
        [DataMember]
        public string TeamName { get; set; }
    }
}
