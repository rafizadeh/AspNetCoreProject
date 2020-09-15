using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Explanation { get; set; }

        public string Photo { get; set; }

        public int PortfolioCategoryId { get; set; }

        public PortfolioCategory PortfolioCategory { get; set; }
    }
}
