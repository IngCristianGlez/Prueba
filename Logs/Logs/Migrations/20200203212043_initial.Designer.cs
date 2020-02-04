﻿// <auto-generated />
using Logs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Logs.Migrations
{
    [DbContext(typeof(Prueba2Context))]
    [Migration("20200203212043_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Logs.Models.Log", b =>
                {
                    b.Property<int>("IdLog")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idLog")
                        .HasColumnType("int(11)");

                    b.Property<string>("DateRegister")
                        .IsRequired()
                        .HasColumnName("Date_Register")
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "latin1")
                        .HasAnnotation("MySql:Collation", "latin1_swedish_ci");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasAnnotation("MySql:CharSet", "latin1")
                        .HasAnnotation("MySql:Collation", "latin1_swedish_ci");

                    b.HasKey("IdLog")
                        .HasName("PRIMARY");

                    b.ToTable("Log");
                });
#pragma warning restore 612, 618
        }
    }
}
