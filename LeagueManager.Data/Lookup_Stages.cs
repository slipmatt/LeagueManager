//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeagueManager.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lookup_Stages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lookup_Stages()
        {
            this.EventTeams = new HashSet<EventTeam>();
        }
    
        public int StageId { get; set; }
        public string StageName { get; set; }
        public bool IsKnockout { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventTeam> EventTeams { get; set; }
    }
}
