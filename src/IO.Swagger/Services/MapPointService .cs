using Geocoding;
using Geocoding.Google;
using GeoCoordinatePortable;
using IO.Swagger.Models;
using IO.Swagger.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using IO.Swagger.Models;
using IO.Swagger.Services.Interfaces;
using IO.Swagger.Repositories.Interfaces;

namespace IO.Swagger.Services
{
    public class MapPointService : IMapPointService
    {
        private IMapPointRepository repository;

        public MapPointService(IMapPointRepository repository)
        {
            this.repository = repository;
        }


        public IEnumerable<MapPointDTO> GetFencedData(double neLat, double neLong, double swLat, double swLong)
        {
            var nePoint = new GeoCoordinate(neLat, neLong);
            var swPoint = new GeoCoordinate(swLat, swLong);
            var mapPoints = this.repository.GetAll();

            var points = mapPoints.Where(m => new GeoCoordinate(m.Latitude, m.Longitude).isWithin(swPoint, nePoint));

            return points.Select(p => new MapPointDTO(p.Latitude, p.Longitude, p.MetaData));
        }


        public Guid AddMapdData(MapPointDTO mapPoint)
        {
            Database.MapPoint tosave = new Database.MapPoint()
            {
                Latitude = mapPoint.Latitude,
                Longitude = mapPoint.Longitude,
                MetaData = mapPoint.MetaData };
            try
            {
                repository.Insert(tosave);
                return tosave.Id;
            }

            catch(Exception e)
            {
                throw new Exception("Could not save map point");
            }

        }

    }

}
