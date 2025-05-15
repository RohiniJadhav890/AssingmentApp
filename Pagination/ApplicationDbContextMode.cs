using AssingmentApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AssingmentApp.Pagination
{
    [DbContext(typeof(ApplicationDBConntext))]
    public partial class ApplicationDbContextMode : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AAsignmentNimap.Models.Category", b =>
            {
                b.Property<int>("CategoryId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                b.Property<string>("CategoryName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("CategoryId");

                b.ToTable("Categories");
            });

            modelBuilder.Entity("AAsignmentNimap.Models.Product", b =>
            {
                b.Property<int>("ProductId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                b.Property<int>("CategoryId")
                    .HasColumnType("int");

                b.Property<string>("ProductName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ProductId");

                b.ToTable("Products");
            });
#pragma warning restore 612, 618
        }
    }
}
