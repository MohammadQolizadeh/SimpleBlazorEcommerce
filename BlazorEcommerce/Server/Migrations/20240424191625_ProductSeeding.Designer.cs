﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240424191625_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "مروری بر دستاوردهای چهل ساله انقلاب اسلامی بر اساس آمارهای بین المللی",
                            ImageUrl = "https://ketabresan.net/upload/books/9e22b3ef92dbdc9ba314dc39a1ddb160.jpg",
                            Price = 9.99m,
                            Title = "صعود 40 ساله"
                        },
                        new
                        {
                            Id = 2,
                            Description = "کتاب تنها گریه کن به قلم زیبای اکرم اسلامی، نگاهی کوتاه بر روزها و ساعات و لحظه‌های بانویی است که عمر پر‌فراز و نشیب او، چه در مبارزات شب‌شکن دوران انقلاب و چه در روزهای دفاع مقدس سرشار از ولایتمداری است؛و فرجام شیوه زندگانی او فرزندی است که با شهادت خود اندوهی لبریز از افتخار را برای مادرانه‌های قصه رقم می زند.",
                            ImageUrl = "https://ketabresan.net/upload/books/cec3b99b05d3f5fba3d5b83b7b33e8bc.webp",
                            Price = 7.99m,
                            Title = "تنها گریه کن"
                        },
                        new
                        {
                            Id = 3,
                            Description = "«مسافر کربلا» نام اثری از مجموعه فرهنگی شهید ابراهیم هادی، است که به روایت زندگی شهید نوجوان، علیرضا کریمی می پردازد.",
                            ImageUrl = "https://ketabresan.net/upload/books/3581fddea4ce02a468ef2c591e68dacb.webp",
                            Price = 6.99m,
                            Title = "مسافر کربلا"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
