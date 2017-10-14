using Geocoding;
using Geocoding.Google;
using GeoCoordinatePortable;
using IO.Swagger.Models;
using IO.Swagger.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IO.Swagger.Services
{
    public class MapPointService
    {
        private IMapPointRepository repository;

        public MapPointService(IMapPointRepository repository)
        {
            this.repository = repository;
        }


        public IEnumerable<MapPoint> GetFencedData(double neLat, double neLong, double swLat, double swLong)
        {
            var nePoint = new GeoCoordinate(neLat, neLong);
            var swPoint = new GeoCoordinate(swLat, swLong);
            var mapPoints = this.repository.GetAll();

            var points = mapPoints.Where(m => new GeoCoordinate(m.Latitude, m.Longitude).isWithin(swPoint, nePoint));

            return points.Select(p => new MapPoint(p.Latitude, p.Longitude, p.MetaData));
        }

    }

}
