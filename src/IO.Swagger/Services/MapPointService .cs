using Geocoding;
using Geocoding.Google;
using GeoCoordinatePortable;
using IO.Swagger.Models;
using IO.Swagger.Repositories;
using System;
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


        public IEquatable<MapPoint> GetFencedData(string neLat, string neLong, string swLat, string swLong)
        {
            var mapPoints = this.repository.GetAll();
            var geoPoints = mapPoints.Select(x => new GeoCoordinate());

            throw new NotImplementedException();
        }

    }

}
