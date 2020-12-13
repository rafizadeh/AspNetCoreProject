using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.Areas.Admin.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage ="Ad Soyad maksimum 50 xarakter ola bilər")]
        public string Fullname { get; set; }

        [StringLength(50, ErrorMessage = "Email maksimum 50 xarakter ola bilər")]
        public string Email { get; set; }

        [StringLength(50, ErrorMessage = "Şifrə maksimum 50 xarakter ola bilər")]
        public string Password { get; set; }
    }
}
