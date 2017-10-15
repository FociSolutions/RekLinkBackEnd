using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Models
{
    public static class GeoPointExtensionsDTO
    {
        public static Boolean isWithin(this GeoCoordinate pt, GeoCoordinate sw, GeoCoordinate ne)
        {
            return pt.Latitude >= sw.Latitude &&
                   pt.Latitude <= ne.Latitude &&
                   pt.Longitude >= sw.Longitude &&
                   pt.Longitude <= ne.Longitude;
        }
    }
}
