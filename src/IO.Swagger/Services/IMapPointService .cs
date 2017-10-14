using Geocoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Repositories
{
    interface IMapPointService
    {
        IGeocoder CreateAsyncGeocoder();
    }
}
