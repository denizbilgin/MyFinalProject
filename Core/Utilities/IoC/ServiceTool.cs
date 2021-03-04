using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {
        //Bu tool'un amacı DependencyInjection ile oluşan (instancesi oluşan) Servisleri Kullanacağımız yere yazarız
        //yani örneğin (MemoryCacheManagerdeki kod satırı) : _memoryCache = ServiceTool.ServiceProvider.GetService<IMemoryCache>(); bu koda bakalım
        //Burada IMermoryCache'nin hazır instancesine diyoruz ki,seni burada kullanacağım.
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
