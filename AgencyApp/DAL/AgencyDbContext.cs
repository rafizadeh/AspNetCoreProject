using AgencyApp.Areas.Admin.Models;
using AgencyApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.DAL
{
    public class AgencyDbContext : DbContext
    {
        public AgencyDbContext(DbContextOptions<AgencyDbContext> options) : base(options) { }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<PortfolioCategory> PortfolioCategories { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Social> Socials { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
