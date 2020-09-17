using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Slug { get; set; }

        [Required]
        [MinLength(500)]
        public string Text { get; set; }

        [Required]
        [StringLength(70)]
        public string Author { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile[] Files { get; set; }
    }
}
