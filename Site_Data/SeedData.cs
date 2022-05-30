using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GeekTime.Site_Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GeekTimeContext(serviceProvider.GetRequiredService<DbContextOptions<GeekTimeContext>>()))
            {
                /*
                List<Country> countries = new List<Country>()
                {
                    new Country(){ Name = "Bangladesh", ShortName = "BD"},
                    new Country(){ Name = "India", ShortName = "IND"},
                    new Country(){ Name = "Canada", ShortName = "CAN"}
                };

                context.Country.AddRange(countries);
                context.SaveChanges();
                */
            }
        }
    }
}