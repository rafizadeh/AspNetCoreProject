using AgencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.ViewModels
{
    public class HomeViewModel
    {
        public Setting Setting { get; set; }

        public About About { get; set; }

        public List<PortfolioCategory> PortfolioCategories { get; set; }

        public List<Portfolio> Portfolios { get; set; }

        public List<Blog> Blogs { get; set; }

        public List<Social> Socials { get; set; }

        public Contact Contact { get; set; }
    }
}
