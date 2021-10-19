﻿// <auto-generated />
using System;
using Licenta.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Licenta.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211019151102_DB-Arhitecture")]
    partial class DBArhitecture
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Licenta.Models.DataBaseModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataBaseModels");
                });

            modelBuilder.Entity("Licenta.Models.Relations.Many_to_Many.Ingrediente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategorieIngredientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Categorie_ingredient")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCategorieIngredient")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nume_ingredient")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategorieIngredientId");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.Bucatari", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume_bucarat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudonume_bucarat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bucatar");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.CategoriiIngrediente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere_categorie_ingredient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume_categoriie_ingredient")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategorieIngredient");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.CategoriiRetete", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume_Categorie_Retete")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategorieReteta");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.RetetaIngrediente", b =>
                {
                    b.Property<Guid>("IdReteta")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdIngredient")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cantitate_Ingredient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUnitati")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Observatii")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UnitateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdReteta", "IdIngredient");

                    b.HasIndex("IdIngredient");

                    b.HasIndex("UnitateId");

                    b.ToTable("RetetaIngredient");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.Retete", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BucatarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategorieRetetaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere_reteta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdBucatar")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCategorieReteta")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link_reteta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume_reteta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poza_reteta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Scor_retea")
                        .HasColumnType("real");

                    b.Property<int>("durata_gatire")
                        .HasColumnType("int");

                    b.Property<int>("durata_preparare")
                        .HasColumnType("int");

                    b.Property<int>("durata_totala")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BucatarId");

                    b.HasIndex("CategorieRetetaId");

                    b.ToTable("Reteta");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.Unitati", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume_unitate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unitate");
                });

            modelBuilder.Entity("Licenta.Models.Relations.Many_to_Many.Ingrediente", b =>
                {
                    b.HasOne("Licenta.Models.Relations.One_to_Many.CategoriiIngrediente", "CategorieIngredient")
                        .WithMany("Ingrediente")
                        .HasForeignKey("CategorieIngredientId");

                    b.Navigation("CategorieIngredient");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.RetetaIngrediente", b =>
                {
                    b.HasOne("Licenta.Models.Relations.Many_to_Many.Ingrediente", "Ingredient")
                        .WithMany("RetetaIngredient")
                        .HasForeignKey("IdIngredient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Licenta.Models.Relations.One_to_Many.Retete", "Reteta")
                        .WithMany("RetetaIngredient")
                        .HasForeignKey("IdReteta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Licenta.Models.Relations.One_to_Many.Unitati", "Unitate")
                        .WithMany("ReteteIngrediente")
                        .HasForeignKey("UnitateId");

                    b.Navigation("Ingredient");

                    b.Navigation("Reteta");

                    b.Navigation("Unitate");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.Retete", b =>
                {
                    b.HasOne("Licenta.Models.Relations.One_to_Many.Bucatari", "Bucatar")
                        .WithMany("Retete")
                        .HasForeignKey("BucatarId");

                    b.HasOne("Licenta.Models.Relations.One_to_Many.CategoriiRetete", "CategorieReteta")
                        .WithMany("Retete")
                        .HasForeignKey("CategorieRetetaId");

                    b.Navigation("Bucatar");

                    b.Navigation("CategorieReteta");
                });

            modelBuilder.Entity("Licenta.Models.Relations.Many_to_Many.Ingrediente", b =>
                {
                    b.Navigation("RetetaIngredient");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.Bucatari", b =>
                {
                    b.Navigation("Retete");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.CategoriiIngrediente", b =>
                {
                    b.Navigation("Ingrediente");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.CategoriiRetete", b =>
                {
                    b.Navigation("Retete");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.Retete", b =>
                {
                    b.Navigation("RetetaIngredient");
                });

            modelBuilder.Entity("Licenta.Models.Relations.One_to_Many.Unitati", b =>
                {
                    b.Navigation("ReteteIngrediente");
                });
#pragma warning restore 612, 618
        }
    }
}