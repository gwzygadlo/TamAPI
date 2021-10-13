using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamAPI.Data.Sql.Data;
using TamAPI.Priority.Data;

namespace Tam.API.Core
{
    public class PrimaryFactory //: IPrimaryFactory
    {
        public PrimaryFactory()
        {
            this.EntityFactory = new EntityFactory();
        }
        public EntityFactory EntityFactory { get; set; }
        public IDataManager CreateDataManager()
        {
            return new SQLDataManager(this.EntityFactory);
        }

    }

    /*
    public interface IPrimaryFactory
    {
        IDataManager CreateDataManager();
        tamEntities CreateEntities();
    }
    */
}
