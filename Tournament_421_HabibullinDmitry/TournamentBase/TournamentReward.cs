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
    
    public partial class TournamentReward
    {
        public int Id_TReward { get; set; }
        public Nullable<int> Id_Tournament { get; set; }
        public Nullable<int> Id_PStats { get; set; }
        public Nullable<int> Place { get; set; }
    
        public virtual PlayerStats PlayerStats { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
