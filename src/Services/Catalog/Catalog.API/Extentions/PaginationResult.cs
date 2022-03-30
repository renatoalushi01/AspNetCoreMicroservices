using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Extentions
{
    public class PaginationResult<T>
    {
        public long Total { get; set; }
        public List<T> Data { get; set; }
    }

}
