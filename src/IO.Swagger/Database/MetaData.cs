using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Database
{
    public class MetaData
    {
        [Key]
        public Guid ID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public MapPoint MapPoint { get; set; }
    }
}
