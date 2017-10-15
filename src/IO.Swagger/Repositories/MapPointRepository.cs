using IO.Swagger.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Repositories.Interfaces;

namespace IO.Swagger.Repositories
{
    public class MapPointRepository : GenericRepository<MapPoint>, IMapPointRepository
    {
        public MapPointRepository(MappingContext context) : base(context)
        {
        }
    }
}
