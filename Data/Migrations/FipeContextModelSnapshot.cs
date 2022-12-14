// <auto-generated />
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(FipeContext))]
    partial class FipeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Model.FipeInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("codeFipe")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("fuel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("fuelAcronym")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("modelYear")
                        .HasColumnType("integer");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("referenceMonth")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("vehicleType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("fipeInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
