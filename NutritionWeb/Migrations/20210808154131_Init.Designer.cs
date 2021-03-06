// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutritionWeb.Data;

namespace NutritionWeb.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210808154131_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NutritionWeb.BusinessLayer.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiseaseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VitaminId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VitaminId");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("NutritionWeb.BusinessLayer.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VitaminId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VitaminId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("NutritionWeb.BusinessLayer.Supplement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("SupplementName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VitaminId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VitaminId");

                    b.ToTable("Supplements");
                });

            modelBuilder.Entity("NutritionWeb.BusinessLayer.Vitamin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VitaminName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vitamins");
                });

            modelBuilder.Entity("NutritionWeb.BusinessLayer.Disease", b =>
                {
                    b.HasOne("NutritionWeb.BusinessLayer.Vitamin", "Vitamin")
                        .WithMany()
                        .HasForeignKey("VitaminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NutritionWeb.BusinessLayer.Food", b =>
                {
                    b.HasOne("NutritionWeb.BusinessLayer.Vitamin", "Vitamin")
                        .WithMany()
                        .HasForeignKey("VitaminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NutritionWeb.BusinessLayer.Supplement", b =>
                {
                    b.HasOne("NutritionWeb.BusinessLayer.Vitamin", "Vitamin")
                        .WithMany()
                        .HasForeignKey("VitaminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
