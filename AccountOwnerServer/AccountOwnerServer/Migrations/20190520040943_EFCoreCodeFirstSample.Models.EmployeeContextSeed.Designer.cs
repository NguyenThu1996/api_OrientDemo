﻿// <auto-generated />
using System;
using AccountOwnerServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountOwnerServer.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20190520040943_EFCoreCodeFirstSample.Models.EmployeeContextSeed")]
    partial class EFCoreCodeFirstSampleModelsEmployeeContextSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccountOwnerServer.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1L,
                            DateOfBirth = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "uncle.bob@gmail.com",
                            FirstName = "Uncle",
                            LastName = "Bob",
                            PhoneNumber = "999-888-7777"
                        },
                        new
                        {
                            EmployeeID = 2L,
                            DateOfBirth = new DateTime(1981, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jan.kirsten@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kirsten",
                            PhoneNumber = "111-222-3333"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
