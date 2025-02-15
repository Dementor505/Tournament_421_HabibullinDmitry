//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_421_HabibullinDmitry.TournamentBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tournament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tournament()
        {
            this.Match = new HashSet<Match>();
            this.TournamentPlace = new HashSet<TournamentPlace>();
            this.TournamentReward = new HashSet<TournamentReward>();
        }
    
        public int Id_Tournament { get; set; }
        public string Name_Tournament { get; set; }
        public Nullable<int> Id_TournamentType { get; set; }
        public Nullable<System.DateTime> StartTournament { get; set; }
        public Nullable<System.DateTime> EndTournament { get; set; }
        public Nullable<int> Winner { get; set; }
        public Nullable<decimal> MoneyPrize { get; set; }
        public Nullable<int> PlayerCount { get; set; }
        public Nullable<int> TGame_Id { get; set; }
        public Nullable<int> Id_TStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Match> Match { get; set; }
        public virtual TournamentGame TournamentGame { get; set; }
        public virtual TournamentLimits TournamentLimits { get; set; }
        public virtual TournamentStatys TournamentStatys { get; set; }
        public virtual TournamentType TournamentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TournamentPlace> TournamentPlace { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TournamentReward> TournamentReward { get; set; }
    }
}
