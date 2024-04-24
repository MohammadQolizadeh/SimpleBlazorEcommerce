namespace BlazorEcommerce.Server.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                  new Product
                  {
                      Id = 1,
                      Title = "صعود 40 ساله",
                      Description = "مروری بر دستاوردهای چهل ساله انقلاب اسلامی بر اساس آمارهای بین المللی",
                      ImageUrl = "https://ketabresan.net/upload/books/9e22b3ef92dbdc9ba314dc39a1ddb160.jpg",
                      Price = 9.99m,

                  },
                new Product
                {
                    Id = 2,
                    Title = "تنها گریه کن",
                    Description = "کتاب تنها گریه کن به قلم زیبای اکرم اسلامی، نگاهی کوتاه بر روزها و ساعات و لحظه‌های بانویی است که عمر پر‌فراز و نشیب او، چه در مبارزات شب‌شکن دوران انقلاب و چه در روزهای دفاع مقدس سرشار از ولایتمداری است؛و فرجام شیوه زندگانی او فرزندی است که با شهادت خود اندوهی لبریز از افتخار را برای مادرانه‌های قصه رقم می زند.",
                    ImageUrl = "https://ketabresan.net/upload/books/cec3b99b05d3f5fba3d5b83b7b33e8bc.webp",
                    Price = 7.99m,

                },
                new Product
                {
                    Id = 3,
                    Title = "مسافر کربلا",
                    Description = "«مسافر کربلا» نام اثری از مجموعه فرهنگی شهید ابراهیم هادی، است که به روایت زندگی شهید نوجوان، علیرضا کریمی می پردازد.",
                    ImageUrl = "https://ketabresan.net/upload/books/3581fddea4ce02a468ef2c591e68dacb.webp",
                    Price = 6.99m,

                });
        }
        public DbSet<Product> Products { get; set; }

    }
}
