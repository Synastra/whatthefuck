using System;
using CoreApp.Data;

namespace CoreApp.Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CoreApp:Setup Starting...");
            using (var context = new CoreDbContext())
            {
                context.Database.EnsureCreated();
                // Add your context here
                context.SaveChanges();
            }
            Console.WriteLine("CoreApp:Setup Done!");
        }
    }
}
