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

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string MetaData { get; set; }

    }
}
