using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RentCore.Models.Entitites;


public partial class RENTCARdbContext : DbContext
{

    public RENTCARdbContext()
    {

    }

    public RENTCARdbContext(DbContextOptions<RENTCARdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auto> Autos { get; set; } = null!;
    public virtual DbSet<Clienti> Clientis { get; set; } = null!;
    public virtual DbSet<Contratti> Contrattis { get; set; } = null!;
    public virtual DbSet<Marche> Marches { get; set; } = null!;
    public virtual DbSet<Modelli> Modellis { get; set; } = null!;
    public virtual DbSet<Spese> Speses { get; set; } = null!;
    public virtual DbSet<TipiSpese> TipiSpeses { get; set; } = null!;
    public virtual DbSet<Utenti> Utentis { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlite("Data Source=Data/RENTCAR.db");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auto>(entity =>
        {
            entity.HasKey(e => e.IdAuto);

            entity.ToTable("Auto");

            entity.Property(e => e.Costo).HasColumnType("DECIMAL(7,2)");

            entity.Property(e => e.DataAcquisto).HasColumnType("DATE");

            entity.Property(e => e.Targa).HasColumnType("TEXT(7)");
        });

        modelBuilder.Entity<Clienti>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("Clienti");

            entity.Property(e => e.Cap)
                .HasColumnType("TEXT(10)")
                .HasColumnName("CAP");

            entity.Property(e => e.Citta).HasColumnType("TEXT(50)");

            entity.Property(e => e.CodiceFiscale).HasColumnType("TEXT(16)");

            entity.Property(e => e.Indirizzo).HasColumnType("TEXT(50)");

            entity.Property(e => e.PartitaIva).HasColumnType("TEXT(11)");

            entity.Property(e => e.Provincia).HasColumnType("TEXT(2)");

            entity.Property(e => e.RagioneSociale).HasColumnType("TEXT(50)");
        });

        modelBuilder.Entity<Contratti>(entity =>
        {
            entity.HasKey(e => e.IdContratto);

            entity.ToTable("Contratti");

            entity.Property(e => e.DataFine).HasColumnType("DATE");

            entity.Property(e => e.DataInizio).HasColumnType("DATE");
        });

        modelBuilder.Entity<Marche>(entity =>
        {
            entity.HasKey(e => e.IdMarca);

            entity.ToTable("Marche");

            entity.Property(e => e.DescrizioneMarca).HasColumnType("TEXT(50)");
        });

        modelBuilder.Entity<Modelli>(entity =>
        {
            entity.HasKey(e => e.IdModello);

            entity.ToTable("Modelli");

            entity.Property(e => e.NomeModello).HasColumnType("TEXT(50)");
        });

        modelBuilder.Entity<Spese>(entity =>
        {
            entity.HasKey(e => e.IdSpesa);

            entity.ToTable("Spese");

            entity.Property(e => e.DataSpesa).HasColumnType("DATE");

            entity.Property(e => e.Importo).HasColumnType("DECIMAL(18,2)");

            entity.HasOne(d => d.IdTipoSpesaNavigation)
                .WithMany(p => p.Speses)
                .HasForeignKey(d => d.IdTipoSpesa);
        });

        modelBuilder.Entity<TipiSpese>(entity =>
        {
            entity.HasKey(e => e.IdTipoSpesa);

            entity.ToTable("TipiSpese");

            entity.Property(e => e.Descrizione).HasColumnType("TEXT (100)");
        });

        modelBuilder.Entity<Utenti>(entity =>
        {
            entity.HasKey(e => e.IdUtente);

            entity.ToTable("Utenti");

            entity.Property(e => e.NomeUtente).HasColumnType("TEXT(50)");

            entity.Property(e => e.Pwd).HasColumnType("TEXT(50)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
