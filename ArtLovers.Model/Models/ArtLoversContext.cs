﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ArtLovers.Model.Models;

public partial class ArtLoversContext : DbContext
{
    public ArtLoversContext()
    {
    }

    public ArtLoversContext(DbContextOptions<ArtLoversContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Arte> Arte { get; set; }

    public virtual DbSet<Cartao> Cartao { get; set; }

    public virtual DbSet<Comentario> Comentario { get; set; }

    public virtual DbSet<Comunidade> Comunidade { get; set; }

    public virtual DbSet<Pessoa> Pessoa { get; set; }

    public virtual DbSet<Publicacao> Publicacao { get; set; }

    public virtual DbSet<Tag> Tag { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Arte>(entity =>
        {
            entity.HasKey(e => e.IdArte).HasName("PK__Arte__750EB095939AAA90");

            entity.Property(e => e.IdArte).HasColumnName("idArte");
            entity.Property(e => e.Arte1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Arte");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
        });

        modelBuilder.Entity<Cartao>(entity =>
        {
            entity.HasKey(e => e.IdCartao).HasName("PK__Cartao__C212DE25FE6C38B2");

            entity.Property(e => e.IdCartao).HasColumnName("idCartao");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.NumeroCartao)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.TipoCartao)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.IdComentario).HasName("PK__Comentar__C74515DADD3F37EC");

            entity.Property(e => e.IdComentario).HasColumnName("idComentario");
            entity.Property(e => e.Comentario1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Comentario");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
        });

        modelBuilder.Entity<Comunidade>(entity =>
        {
            entity.HasKey(e => e.IdComunidade).HasName("PK__Comunida__2EED2F8AAD0B08FE");

            entity.Property(e => e.IdComunidade).HasColumnName("idComunidade");
            entity.Property(e => e.Comunidade1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Comunidade");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.IdPessoa).HasName("PK__Pessoa__83D303D0882365BE");

            entity.Property(e => e.IdPessoa).HasColumnName("idPessoa");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.IdArte).HasColumnName("idArte");
            entity.Property(e => e.IdCartao).HasColumnName("idCartao");
            entity.Property(e => e.IdPublicacao).HasColumnName("idPublicacao");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.IdArteNavigation).WithMany(p => p.Pessoa)
                .HasForeignKey(d => d.IdArte)
                .HasConstraintName("FK__Pessoa__idArte__2E1BDC42");

            entity.HasOne(d => d.IdCartaoNavigation).WithMany(p => p.Pessoa)
                .HasForeignKey(d => d.IdCartao)
                .HasConstraintName("FK__Pessoa__idCartao__2F10007B");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.Pessoa)
                .HasForeignKey(d => d.IdPublicacao)
                .HasConstraintName("FK__Pessoa__idPublic__36B12243");
        });

        modelBuilder.Entity<Publicacao>(entity =>
        {
            entity.HasKey(e => e.IdPublicacao).HasName("PK__Publicac__4E1B5774AE89A6CF");

            entity.Property(e => e.IdPublicacao).HasColumnName("idPublicacao");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.IdArte).HasColumnName("idArte");
            entity.Property(e => e.IdComentario).HasColumnName("idComentario");
            entity.Property(e => e.IdComunidade).HasColumnName("idComunidade");
            entity.Property(e => e.IdPessoa).HasColumnName("idPessoa");
            entity.Property(e => e.IdTag).HasColumnName("idTag");

            entity.HasOne(d => d.IdArteNavigation).WithMany(p => p.Publicacao)
                .HasForeignKey(d => d.IdArte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Publicaca__idArt__32E0915F");

            entity.HasOne(d => d.IdComentarioNavigation).WithMany(p => p.Publicacao)
                .HasForeignKey(d => d.IdComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Publicaca__idCom__33D4B598");

            entity.HasOne(d => d.IdComunidadeNavigation).WithMany(p => p.Publicacao)
                .HasForeignKey(d => d.IdComunidade)
                .HasConstraintName("FK__Publicaca__idCom__34C8D9D1");

            entity.HasOne(d => d.IdPessoaNavigation).WithMany(p => p.Publicacao)
                .HasForeignKey(d => d.IdPessoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Publicaca__idPes__31EC6D26");

            entity.HasOne(d => d.IdTagNavigation).WithMany(p => p.Publicacao)
                .HasForeignKey(d => d.IdTag)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Publicaca__idTag__35BCFE0A");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.IdTag).HasName("PK__Tag__020FEDB8B3753306");

            entity.Property(e => e.IdTag).HasColumnName("idTag");
            entity.Property(e => e.Tag1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tag");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}