using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgencyApp.Models;

namespace AgencyApp.DAL
{
    public class SeedData
    {
        static public void Initial(IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AgencyDbContext>();

                InitialAbout(db);
                InitialBlog(db);
                InitialPortfolioCategory(db);
                InitialPortfoilo(db);
                InitialSetting(db);
                InitialSocial(db);
            }
        }

        private static void InitialAbout(AgencyDbContext db)
        {
            if (!db.Abouts.Any())
            {
                db.Abouts.Add(new About
                {
                    Photo = "profile-2.jpg",
                    Text = "For instance, whenever I go back to the guest house during the morning to copy out the contract, these gentlemen are always still sitting there eating their breakfasts. I ought to just try that witht my boss; I'd get kicked out on the spot. But who knows, maybe that would be the best thing for me. He'd fall right off his desk! And it's a funny sort of business to be sitting up there at your desk, talking down at your subordinates. I ought to just try that witht my boss; I'd get kicked out on the spot. But who knows, maybe that would be the best thing for me. He'd fall right off his desk! And it's a funny sort of business to be sitting up there at your desk, talking down at your subordinates."
                });

                db.SaveChanges();
            }
        }

        private static void InitialBlog(AgencyDbContext db)
        {
            if (!db.Blogs.Any())
            {
                db.AddRange(new[] {
                    new Blog
                    {
                        Title = "By spite about do of do allow blush",
                        Slug = "by-spite-about-do-of-do-allow-blush",
                        Author = "Larry Stark",
                        Date = new DateTime(2020, 5, 25),
                        Photo = "blog-1.jpg"
                    },
                    new Blog
                    {
                        Title = "Two Before Arrow Not Relied",
                        Slug = "two-before-arrow-not-relied",
                        Author = "Cabbar Gasanov",
                        Date = new DateTime(2019, 10, 25),
                        Photo = "blog-6.png"
                    },
                    new Blog
                    {
                        Title = "Behind Sooner Dining so Window ",
                        Slug = "behind-sooner-dining-so-window",
                        Author = "Akber Aghayev",
                        Date = new DateTime(2007, 10, 22),
                        Photo = "blog-6.png"
                    }
                });
                db.SaveChanges();
            }
        }

        private static void InitialPortfolioCategory(AgencyDbContext db)
        {
            if (!db.PortfolioCategories.Any())
            {
                db.PortfolioCategories.AddRange(new[] {
                    new PortfolioCategory
                    {
                        Name = "Web Design"
                    },
                    new PortfolioCategory
                    {
                        Name = "Development"
                    },
                    new PortfolioCategory
                    {
                        Name = "Applications"
                    }
                });

                db.SaveChanges();
            }

        }


        private static void InitialPortfoilo(AgencyDbContext db)
        {
            if (!db.Portfolios.Any())
            {
                db.Portfolios.AddRange(new[] {
                    new Portfolio
                    {
                        Name = "Biggest Cover",
                        Photo = "work-1.jpg",
                        PortfolioCategoryId = 1
                    },
                    new Portfolio
                    {
                        Name = "Easy Documentation",
                        Photo = "work-2.jpg",
                        PortfolioCategoryId = 2
                    },
                    new Portfolio
                    {
                        Name = "Cup of Coffee",
                        Photo = "work-3.jpg",
                        PortfolioCategoryId = 3
                    },
                    new Portfolio
                    {
                        Name = "Bag Design",
                        Photo = "work-4.jpg",
                        PortfolioCategoryId = 1
                    },
                    new Portfolio
                    {
                        Name = "CD Cover",
                        Photo = "work-5.jpg",
                        PortfolioCategoryId = 2
                    },
                    new Portfolio
                    {
                        Name = "The Notebook",
                        Photo = "work-6.jpg",
                        PortfolioCategoryId = 3
                    }
                });

                db.SaveChanges();
            }
        }

        private static void InitialSetting(AgencyDbContext db)
        {
            if (!db.Settings.Any())
            {
                db.Settings.Add(new Setting
                {
                    Address = "1444 S. Alameda Street Los Angeles, California 90021",
                    Email = "raufgr@code.edu.az",
                    PhoneNumber = "0800 123 456789"
                });
                db.SaveChanges();
            }
        }

        private static void InitialSocial(AgencyDbContext db)
        {
            if (!db.Socials.Any())
            {
                db.Socials.AddRange(new[] {
                    new Social
                    {
                        Name = "facebook",
                        Icon = "fa-facebook",
                        Url = "facebook.com"
                    },
                    new Social
                    {
                        Name = "twitter",
                        Icon = "fa-twitter",
                        Url = "twitter.com"
                    },
                    new Social
                    {
                        Name = "instagram",
                        Icon = "fa-instagram",
                        Url = "instagram.com"
                    },
                    new Social
                    {
                        Name = "behance",
                        Icon = "fa-behance",
                        Url = "behance.com"
                    },
                    new Social
                    {
                        Name = "dribbble",
                        Icon = "fa-dribbble",
                        Url = "dribbble.com"
                    },
                });
                db.SaveChanges();
            }
        }

    }
}
