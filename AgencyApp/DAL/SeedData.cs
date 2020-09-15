using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.DAL
{
    public class SeedData
    {
        static public void Initial(IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AgencyDbContext>();
            }
        }

    }
}
