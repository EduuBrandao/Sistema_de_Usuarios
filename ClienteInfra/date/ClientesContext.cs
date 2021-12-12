﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using ClienteInfra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;

#nullable disable

namespace Dados.date
{
    public partial class ClientesContext : DbContext
    {
        private readonly ConnectionStrings connectionStringsConfig;
        public ClientesContext(IOptions<ConnectionStrings> connectionStringsCofingOptions)
        {
            connectionStringsConfig = connectionStringsCofingOptions.Value;
        }

        public ClientesContext(DbContextOptions<ClientesContext> options , IOptions<ConnectionStrings> connectionStringsCofingOptions)
            : base(options)
        {
            connectionStringsConfig = connectionStringsCofingOptions.Value;
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Teste> Teste { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = string.Format(connectionStringsConfig.DefaultConnection);

            optionsBuilder.UseSqlServer(connString, options => options.CommandTimeout(1800));

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .IsUnicode(true)
                    .HasColumnName("id");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sobrenome");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Teste>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("teste");

                entity.Property(e => e.Horario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horario");

                entity.Property(e => e.Teste1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teste");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}