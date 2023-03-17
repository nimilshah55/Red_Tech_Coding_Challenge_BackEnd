// This is a generated code file for a migration in Entity Framework Core. It includes a class named InitialMigration that inherits from Migration and overrides the BuildTargetModel method.

// The BuildTargetModel method is used to create the database schema for the application's models. 
// In this case, it defines a single entity named Order with five properties (Id, OrderType, CustomerName, CreatedDate, and CreatedByUsername). It sets the primary key of the Order entity to the Id property and specifies that the entity should be mapped to a table named "Orders" in the database.

// The SqlServerModelBuilderExtensions.UseIdentityColumns method is called to 
// indicate that the Id property should be an identity column in the database.

// The [DbContext(typeof(OrdersAPIDbContext))] attribute on the
// InitialMigration class specifies the type of the DbContext that this migration applies to.
// The [Migration("20230119083437_Initial Migration")] attribute specifies the name of the migration.

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrdersAPI.Data;

#nullable disable

namespace OrdersAPI.Migrations
{
    [DbContext(typeof(OrdersAPIDbContext))]
    [Migration("20230119083437_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrdersAPI.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
