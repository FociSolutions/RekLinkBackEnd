using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Database
{
    public class MapPoint
    {
        [Key]
        public Guid Id { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string MetaData { get; set; }

    }
}
