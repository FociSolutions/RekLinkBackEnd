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
        public decimal Key { get; set; }
        public decimal Value { get; set; }
    }
}
