using IO.Swagger.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Repositories
{
    public class MapPointRepository : GenericRepository<MapPoint>
    {
        public MapPointRepository(MappingContext context) : base(context)
        {
        }
    }
}
