using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Explanation { get; set; }

        public string Photo { get; set; }

        public int PortfolioCategoryId { get; set; }

        public PortfolioCategory PortfolioCategory { get; set; }
    }
}
