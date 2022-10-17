using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Devops.Tp1.Domain
{
    public static class PrepGameDb
    {
        public static void PrePoluation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                AddData(serviceScope.ServiceProvider.GetService<GameContext>()); 
            }
            
        }
        public static void AddData(GameContext context)
        {
            System.Console.WriteLine("Appling Migration...");
            context.Database.Migrate();
        }
    }
}
