//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proj_EF_Formula1_DBFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FIA2022Context : DbContext
    {
        public FIA2022Context()
            : base("name=FIA2022Context")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carro> Carro { get; set; }
        public virtual DbSet<Equipe> Equipe { get; set; }
        public virtual DbSet<Piloto> Piloto { get; set; }
        public virtual DbSet<PilotoCarro> PilotoCarro { get; set; }
    }
}
