﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyEvents.API.Data.Context;

namespace MyEvents.API.Data.Migrations.Migration001
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("MyEvents.API.Models.Evento", b =>
                {
                    b.Property<uint>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataEvento")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Local")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lote")
                        .HasColumnType("TEXT");

                    b.Property<int>("QtdParticipantes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tema")
                        .HasColumnType("TEXT");

                    b.HasKey("IdEvento");

                    b.ToTable("Cad_Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
