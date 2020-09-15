using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Address { get; set; }

        [Required]
        [StringLength(300)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }
    }
}
