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
    
    public partial class GClassPreference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GClassPreference()
        {
            this.TournamentPlace = new HashSet<TournamentPlace>();
        }
    
        public int Id_GCP { get; set; }
        public Nullable<int> Id_TPlace { get; set; }
        public Nullable<int> Id_GClass { get; set; }
    
        public virtual GamingClass GamingClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TournamentPlace> TournamentPlace { get; set; }
    }
}