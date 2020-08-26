using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Crud_Rueda.Models
{
    public partial class PessoaContext : DbContext
    {
        public PessoaContext()
        {
        }

        public PessoaContext(DbContextOptions<PessoaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pessoas> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-C9NH199;Database=Pessoa;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoas>(entity =>
            {
                entity.HasKey(e => e.IdPessoa)
                    .HasName("PK__Pessoas__402CBA75C9768E52");

                entity.Property(e => e.IdPessoa).HasColumnName("id_Pessoa");

                entity.Property(e => e.DataNasc).HasColumnType("date");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
