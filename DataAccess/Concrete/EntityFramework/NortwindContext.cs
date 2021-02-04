using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context nesneleri Db tabloları ile proje classlarını ilişkilendiren classlardır
    //DbContext yazarak onun bir context olduğunu belirttik
    public class NortwindContext:DbContext
    {
        //Bu metot projenin hangi veritabanı ile ilişkili olacağını belirttiğimiz metottur
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        //Bu benim product nesnemi Products isimli tabloya bağla demektir
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
