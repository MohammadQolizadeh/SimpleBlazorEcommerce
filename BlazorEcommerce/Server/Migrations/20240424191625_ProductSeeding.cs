using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "مروری بر دستاوردهای چهل ساله انقلاب اسلامی بر اساس آمارهای بین المللی", "https://ketabresan.net/upload/books/9e22b3ef92dbdc9ba314dc39a1ddb160.jpg", 9.99m, "صعود 40 ساله" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "کتاب تنها گریه کن به قلم زیبای اکرم اسلامی، نگاهی کوتاه بر روزها و ساعات و لحظه‌های بانویی است که عمر پر‌فراز و نشیب او، چه در مبارزات شب‌شکن دوران انقلاب و چه در روزهای دفاع مقدس سرشار از ولایتمداری است؛و فرجام شیوه زندگانی او فرزندی است که با شهادت خود اندوهی لبریز از افتخار را برای مادرانه‌های قصه رقم می زند.", "https://ketabresan.net/upload/books/cec3b99b05d3f5fba3d5b83b7b33e8bc.webp", 7.99m, "تنها گریه کن" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "«مسافر کربلا» نام اثری از مجموعه فرهنگی شهید ابراهیم هادی، است که به روایت زندگی شهید نوجوان، علیرضا کریمی می پردازد.", "https://ketabresan.net/upload/books/3581fddea4ce02a468ef2c591e68dacb.webp", 6.99m, "مسافر کربلا" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
