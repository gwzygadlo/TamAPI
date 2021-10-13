using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace TamAPI.Models
{
    public class DataEnvelope<TEntity>
    {
        public TEntity item { get; set; }
        public string message { get; set; }
        public Boolean success { get; set; }
    }
}