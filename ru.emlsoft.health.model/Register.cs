using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ru.emlsoft.data.ef;
using ru.emlsoft.health.dto.Clinic;
using ru.emlsoft.health.model.Clinic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.emlsoft.health.model
{
    public static class Register
    {
        public static void RegisterBase(this IServiceCollection services, string ? connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(connectionString);

            Func<IServiceProvider, IDataModel> factoryDb
                = x => new DataModel(connectionString, x.GetRequiredService<ILogger<DataModel>>());

            services.AddScoped(typeof(IDataModel), factoryDb);

            data.Config.SetupMapping( new KeyValuePair<Type, Type>[] 
            { 
                new KeyValuePair<Type, Type>(typeof(ClinicDto), typeof(Clinic.Clinic)),
                new KeyValuePair<Type, Type>(typeof(DoctorDto), typeof(Doctor))
            });
        }
    }
}
