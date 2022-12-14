// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WireBrainCoffeeEmployeeManager.Data;

#nullable disable

namespace WireBrainCoffeeEmployeeManager.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220911153252_SeedDatabase")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WireBrainCoffeeEmployeeManager.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Human Resource"
                        },
                        new
                        {
                            Id = 5,
                            Name = "IT"
                        });
                });

            modelBuilder.Entity("WireBrainCoffeeEmployeeManager.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 2,
                            FirstName = "Ain",
                            IsDeveloper = false,
                            LastName = "Mor"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 5,
                            FirstName = "Suresh",
                            IsDeveloper = true,
                            LastName = "Mor"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 5,
                            FirstName = "Vivaan",
                            IsDeveloper = true,
                            LastName = "Mor"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 1,
                            FirstName = "Umesh",
                            IsDeveloper = false,
                            LastName = "Mor"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 4,
                            FirstName = "Lokesh",
                            IsDeveloper = false,
                            LastName = "Mor"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 3,
                            FirstName = "Naman",
                            IsDeveloper = false,
                            LastName = "Mor"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 5,
                            FirstName = "Maulik",
                            IsDeveloper = true,
                            LastName = "Mor"
                        });
                });

            modelBuilder.Entity("WireBrainCoffeeEmployeeManager.Models.Employee", b =>
                {
                    b.HasOne("WireBrainCoffeeEmployeeManager.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WireBrainCoffeeEmployeeManager.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
