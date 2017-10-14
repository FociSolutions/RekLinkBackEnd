using IO.Swagger.Models;
using IO.Swagger.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Services
{
    public class MapPointService
    {
        private IMapPointRepository repository;
        public MapPointService(IMapPointRepository repo)
        {
            this.repository = repo;
        }
    }
}
