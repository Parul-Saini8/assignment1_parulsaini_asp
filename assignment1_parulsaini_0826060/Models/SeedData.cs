using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ImperialRulers.Data;
using System;
using System.Linq;

namespace ImperialRulers.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

                using (var context = new ImperialRulersContext(
                serviceProvider.GetRequiredService<DbContextOptions<ImperialRulersContext>>()))
            {
                // Look for any Ruler available
                if (context.Ruler.Any())
                {
                    return;   // DB has been seeded
                }

                context.Ruler.AddRange(
                    new Ruler
                    {
                        BrandName = "Natraj",
                        ManufactureDate = DateTime.Parse("2022-2-12"),
                        Types = "Transparent",
                        Price = 10.1M,
                        Length = 30,
                        Material = "Glass",
                        Rating = "R",
                    },
                     new Ruler
                     {
                         BrandName = "SupremeMeasure",
                         ManufactureDate = DateTime.Parse("2021-1-22"),
                         Types = "Obaque",
                         Price = 20M,
                         Length = 90,
                         Material = "Wood",
                         Rating = "R",
                     },
                      new Ruler
                      {
                          BrandName = "MonarchMeter",
                          ManufactureDate = DateTime.Parse("2022-5-22"),
                          Types = "Transparent",
                          Price = 15M,
                          Length = 100,
                          Material = "Plastic",
                          Rating = "R",
                      },
                       new Ruler
                       {
                           BrandName = "Doms",
                           ManufactureDate = DateTime.Parse("2023-7-12"),
                           Types = "Transparent",
                           Price = 7.99M,
                           Length = 150M,
                           Material = "Plastic",
                           Rating = "R",
                       },
                        new Ruler
                        {
                            BrandName = "NobleRuler",
                            ManufactureDate = DateTime.Parse("2021-2-12"),
                            Types = "Opaque",
                            Price = 12.99M,
                            Length = 200M,
                            Material = "Steel",
                            Rating = "R",
                        },
                         new Ruler
                         {
                             BrandName = "ProMeasure",
                             ManufactureDate = DateTime.Parse("2020-2-26"),
                             Types = "Transparent",
                             Price = 19.99M,
                             Length = 300M,
                             Material = "Plastic",
                             Rating = "R",
                         },
                          new Ruler
                          {
                              BrandName = "PrecisionRulery",
                              ManufactureDate = DateTime.Parse("2023-2-12"),
                              Types = "Opaque",
                              Price = 29.99M,
                              Length = 100M,
                              Material = "Steel",
                              Rating = "R",
                          },
                           new Ruler
                           {
                               BrandName = "MeasureMate",
                               ManufactureDate = DateTime.Parse("2023-2-23"),
                               Types = "Transparent",
                               Price = 9.99M,
                               Length = 150M,
                               Material = "Glass",
                               Rating = "R",
                           },
                            new Ruler
                            {
                                BrandName = "UltraMeter",
                                ManufactureDate = DateTime.Parse("2023-5-23"),
                                Types = "Opaque",
                                Price = 29.99M,
                                Length = 100M,
                                Material = "Wood",
                                Rating = "R",
                            },
                             new Ruler
                             {
                                 BrandName = "LengthWiz",
                                 ManufactureDate = DateTime.Parse("2022-5-12"),
                                 Types = "Transparent",
                                 Price = 19.99M,
                                 Length = 150M,
                                 Material = "Glass",
                                 Rating = "R",
                             }
                );
                context.SaveChanges();
            }
        }
    }

}