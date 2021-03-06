// <auto-generated />
using System;
using InventoryManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryManagement.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20220530114048_CreateNewInventoryDatabase")]
    partial class CreateNewInventoryDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryManagement.Model.InventoryDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessClassSeat");

                    b.Property<DateTime>("EndDateTime");

                    b.Property<string>("FlightNo");

                    b.Property<string>("FromPlace");

                    b.Property<int>("Meal");

                    b.Property<int>("NoOfRows");

                    b.Property<int>("NonBusinessClassSeat");

                    b.Property<double>("Price");

                    b.Property<DateTime>("StartDateTime");

                    b.Property<string>("ToPlace");

                    b.HasKey("id");

                    b.ToTable("inventoryTbls");
                });
#pragma warning restore 612, 618
        }
    }
}
