using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {
        //1. Açıklama
        //------------------
        //Bu tool'un amacı DependencyInjection ile oluşan (instancesi oluşan) Servisleri Kullanacağımız yere yazarız
        //yani örneğin (MemoryCacheManagerdeki kod satırı) : _memoryCache = ServiceTool.ServiceProvider.GetService<IMemoryCache>(); bu koda bakalım
        //Burada IMermoryCache'nin hazır instancesine diyoruz ki,seni burada kullanacağım.

        //2. Açıklama
        //------------------
        //Normalde dependency injection yöntemi ile instance üretebiliyoruz ancak dependency injection kullanılmayan
        //yerlerde de bizim gerekli interface'in instance'ini üretebiliyor olmamız lazım.Nasıl ICarService
        //istediğimde CarManager diyorsam orada da ICarService'i parametre olarak veriyorum dependency injection'a gerek kalmadan 
        //    otomatik olarak CarManager sınıfının instance'ini üretiyor bizim için.
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
