using TelevisionStore.Models;

namespace TelevisionStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TelevisionStore.Models.TelevisionStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TelevisionStore.Models.TelevisionStoreContext context)
        {
            context.Televisions.AddOrUpdate(p => p.Manufacturer,
               new Television
               {
                   Manufacturer = "Sony",
                   Size = 48,
                   Price = 249.99M,
               },
               new Television
               {
                   Manufacturer = "Vizio",
                   Size = 32,
                   Price = 149.99M,
               },
                new Television
               {
                   Manufacturer = "Magnavox",
                   Size = 27,
                   Price = 129.99M,
               }
               );

            context.Employees.AddOrUpdate(p => p.FirstName,
                new Employee
                {
                    FirstName = "Shawn",
                    LastName = "Brumner",
                },
                new Employee
                {
                    FirstName = "Rob",
                    LastName = "Mcgregor",
                },
                new Employee
                {
                    FirstName = "John",
                    LastName = "Money",
                }
                );
            context.Sales.AddOrUpdate(p => p.EmployeeId,
                new Sale
                {
                    EmployeeId = 1,
                    TotalPrice = 529.97M,
                    PaymentMethod = "Credit",
                },
                new Sale
                {
                    EmployeeId = 1,
                    TotalPrice = 249.99M,
                    PaymentMethod = "Cash",
                },
                new Sale
                {
                    EmployeeId = 3,
                    TotalPrice = 129.99M,
                    PaymentMethod = "Credit",
                }
                );
            context.ItemLists.AddOrUpdate(p => p.SaleId,
                new ItemList
                {
                    SaleId = 1,
                    TelevisionId = 1,
                },
                new ItemList
                {
                    SaleId = 1,
                    TelevisionId = 2,
                },
                new ItemList
                {
                    SaleId = 1,
                    TelevisionId = 3,
                },
                new ItemList
                {
                    SaleId = 2,
                    TelevisionId = 1,
                },
                new ItemList
                {
                    SaleId = 3,
                    TelevisionId = 3,
                }
                );
        }
    }
}
