using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.Models
{
    public class About
    {
        public int Id { get; set; }

        [Required]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        [Required]
        [MinLength(500)]
        public string Text { get; set; }
    }
}
