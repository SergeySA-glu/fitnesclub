﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnesClubApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FitnessClubEntities1 : DbContext
    {
        public FitnessClubEntities1()
            : base("name=FitnessClubEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abonement> Abonement { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Trainers> Trainers { get; set; }
    }
}