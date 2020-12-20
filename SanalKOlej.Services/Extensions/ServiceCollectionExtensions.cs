using System;
using Microsoft.Extensions.DependencyInjection;
using SanalKolej.Core.Base;
using SanalKolej.Data.Concrate.EntityFramework.Contexts;
using SanalKolej.DataAccess.Abstract;
using SanalKolej.DataAccess.Concrate;
using SanalKolej.Services.Abstract;
using SanalKolej.Services.Concrate;

namespace SanalKolej.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<SanalKolejContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();

            return serviceCollection;


        }


    }
}
