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

        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public ICollection<MetaData> MetaData { get; set; }

    }
}
