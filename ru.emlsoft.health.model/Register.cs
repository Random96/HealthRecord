using EmlSoft.Data.Ef;
using EmlSoft.Health.Dto.Clinic;
using EmlSoft.Health.model.Clinic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;


namespace EmlSoft.Health.model
{
    public static class Register
    {
        public static void RegisterBase(this IServiceCollection services, string? connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(connectionString);

            Func<IServiceProvider, IDataModel> factoryDb
                = x => new DataModel(connectionString, x.GetRequiredService<ILogger<DataModel>>());

            services.AddScoped(typeof(IDataModel), factoryDb);

            Data.Config.SetupMapping(new KeyValuePair<Type, Type>[]
            {
                new KeyValuePair<Type, Type>(typeof(ClinicDto), typeof(Clinic.Clinic)),
                new KeyValuePair<Type, Type>(typeof(DoctorDto), typeof(Doctor))
            });
        }
    }
}
