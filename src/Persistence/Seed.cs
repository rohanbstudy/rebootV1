using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Activity.Any()) return;

            var activities = new List<Activity>{
                new Activity {
                    Name = "Exercise 1",
                    ActivityCategoryName = "First Category",
                    CreatedDate = DateTime.Now,
                    Description = "Description 1",
                    ModifiedDate = DateTime.Now
                },
                new Activity {
                    Name = "Exercise 2",
                    ActivityCategoryName = "Second Category",
                    CreatedDate = DateTime.Now,
                    Description = "Description 2",
                    ModifiedDate = DateTime.Now
                },
                new Activity {
                    Name = "Exercise 3",
                    ActivityCategoryName = "Third Category",
                    CreatedDate = DateTime.Now,
                    Description = "Description 3",
                    ModifiedDate = DateTime.Now
                },
                new Activity {
                    Name = "Exercise 4",
                    ActivityCategoryName = "Fourth Category",
                    CreatedDate = DateTime.Now,
                    Description = "Description 4",
                    ModifiedDate = DateTime.Now
                }
            };

            await context.Activity.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}