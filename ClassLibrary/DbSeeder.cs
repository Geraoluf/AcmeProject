using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{


    public static class DbSeeder

    {


        public static void Seed(AppDbContext context)
        {
            if (context.SerialNumbers.Any())
                return;

            for (int i = 1; i <= 100; i++)
            {
                context.SerialNumbers.Add(new SerialNumberModel
                {
                    SerialNumber = $"ACME-{i:000}"
                });
            }

            context.SaveChanges();


        }


    }

}
