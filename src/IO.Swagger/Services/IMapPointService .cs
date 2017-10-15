using System;
using System.Collections.Generic;
using IO.Swagger.Models;


namespace IO.Swagger.Services
{
    public interface IMapPointService
    {
        IEnumerable<MapPoint> GetFencedData(double neLat, double neLong, double swLat, double swLong);

        Guid AddMapdData(MapPoint mapPoint);
    }
}
