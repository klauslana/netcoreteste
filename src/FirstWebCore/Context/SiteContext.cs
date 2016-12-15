using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebCore.Models;

namespace FirstWebCore.Context
{
    public class SiteContext : DbContext
    {

        public DbSet<ModelMenuSistema> MenuSistema { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Startup.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModelMenuSistema>().ToTable("pst_MenuSistema");
            modelBuilder.Entity<ModelMenuSistema>().HasKey(x => x.ID);
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.Agrupador).HasColumnName("indagrupador");
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.ClasseIcone).HasColumnName("classicone");
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.Descricao).HasColumnName("descricaomenu");
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.ID).HasColumnName("idmenu");
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.IDAplicativo).HasColumnName("idaplicativo");
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.IDPaginaAplicativo).HasColumnName("idatividade");
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.Link).HasColumnName("link");
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.MeuPai).HasColumnName("meupai");
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.Ordem).HasColumnName("ordem");
            modelBuilder.Entity<ModelMenuSistema>().Property(x => x.SouPai).HasColumnName("indPai");
        }
    }
}
