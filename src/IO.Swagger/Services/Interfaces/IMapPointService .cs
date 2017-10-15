using System;
using System.Collections.Generic;
using IO.Swagger.Models;


namespace IO.Swagger.Services.Interfaces
{
    public interface IMapPointService
    {
        IEnumerable<MapPointDTO> GetFencedData(double neLat, double neLong, double swLat, double swLong);

        Guid AddMapdData(MapPointDTO mapPoint);
    }
}
