﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TournamentDB_421_HabibuLLinEntities : DbContext
    {
        public TournamentDB_421_HabibuLLinEntities()
            : base("name=TournamentDB_421_HabibuLLinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Achivements> Achivements { get; set; }
        public virtual DbSet<GameItems> GameItems { get; set; }
        public virtual DbSet<GamingClass> GamingClass { get; set; }
        public virtual DbSet<GClassPreference> GClassPreference { get; set; }
        public virtual DbSet<GItemsLimits> GItemsLimits { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<MatchPlayer> MatchPlayer { get; set; }
        public virtual DbSet<Moderator> Moderator { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerStats> PlayerStats { get; set; }
        public virtual DbSet<RegionLimits> RegionLimits { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamPlayer> TeamPlayer { get; set; }
        public virtual DbSet<Tournament> Tournament { get; set; }
        public virtual DbSet<TournamentGame> TournamentGame { get; set; }
        public virtual DbSet<TournamentLimits> TournamentLimits { get; set; }
        public virtual DbSet<TournamentPlace> TournamentPlace { get; set; }
        public virtual DbSet<TournamentReport> TournamentReport { get; set; }
        public virtual DbSet<TournamentReward> TournamentReward { get; set; }
        public virtual DbSet<TournamentStatys> TournamentStatys { get; set; }
        public virtual DbSet<TournamentType> TournamentType { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
