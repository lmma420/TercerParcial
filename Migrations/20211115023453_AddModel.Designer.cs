// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TercerParcial.Data;

namespace TercerParcial.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211115023453_AddModel")]
    partial class AddModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TercerParcial.Models.Puntos", b =>
                {
                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("num")
                        .HasColumnType("int");

                    b.Property<string>("ubi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("nombre");

                    b.ToTable("Puntos");
                });
#pragma warning restore 612, 618
        }
    }
}
