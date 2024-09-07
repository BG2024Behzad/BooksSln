
using Microsoft.EntityFrameworkCore;
using BooksStore.Models;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {

                    Name = "سلطنت واژگان",
                    Description = "نیچه مدار",
                    Category = "فلسفه",
                    Price = 150000
                },
                new Product
                {

                    Name = "دیگری",
                    Description = "درباره آزادی و اختیار",
                    Category = "رمان",
                    Price = 95500
                },
                new Product
                {

                    Name = "سقوط لذت",
                    Description = "نقد درباره جامعه‌شناسی ورزش",
                    Category = "علوم اجتماعی",
                    Price = 95500
                },
                new Product
                {

                    Name = "امواج الکترومغناطیسی و سلامت انسان",
                    Description = "ضرر و زیان ناشی از وسایل و تجهیرات برقی",
                    Category = "آموزشی-متفرقه",
                    Price = 29800
                },
                new Product
                {

                    Name = "هستی و زمان",
                    Description = "متافیزیک و هستی شناسی",
                    Category = "فلسفه",
                    Price = 398600
                },

                new Product
                {

                    Name = "امیل",
                    Description = "در باب تربیت",
                    Category = "فلسفه",
                    Price = 206000
                },

                new Product
                {

                    Name = "دومین محاکمه سقراط",
                    Description = "نمایشنامه ای از آلن بدیو",
                    Category = "فلسفه",
                    Price = 398600
                },
                new Product
                {

                    Name = "کتاب هشتم",
                    Description = "توضیحات کتاب هشتم",
                    Category = "موضوع",
                    Price = 465000
                },
                new Product
                {

                    Name = "کتاب نهم",
                    Description = "توضیح",
                    Category = "موضوع",
                    Price = 398600
                }

                );
                context.SaveChanges();
            }
        }
    }
}