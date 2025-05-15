using AssingmentApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssingmentApp.Pagination
{
    [DbContext(typeof(ApplicationDBConntext))]
    [Migration("20250505045812_CategoryDb")]
    public class CategoryDBDesing
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
