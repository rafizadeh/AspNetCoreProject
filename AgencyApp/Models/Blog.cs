using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public DateTime Date { get; set; }

        public string Photo { get; set; }
    }
}
