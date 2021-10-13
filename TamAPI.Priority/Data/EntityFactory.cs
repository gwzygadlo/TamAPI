using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamAPI.Data.Sql.Data;

namespace TamAPI.Priority.Data
{
    public class EntityFactory
    {
        public tamEntities CreateEntities()
        {
            return new tamEntities();
        }
    }
}
