using TamAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TamAPI.Models;
using TamAPI.Data.Sql.Data;
using TamAPI.Priority.Data;
using Tam.API.Core;

namespace TamAPI.Controllers
{
    [RoutePrefix("api/tama")]
    public class TamaController : ApiController
    {
        public TamaController()
        {
            this.PrimaryFactory = new PrimaryFactory();
        }

        public PrimaryFactory PrimaryFactory { get; set; }

        [HttpGet]
        [Route("")]
        public object GetByName(string name = null)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Tama other = dataManager.TamaGetByName(name);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Tama>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpGet]
        [Route("{tama_id}")]
        public object GetbyID(Guid tama_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Tama other = dataManager.TamaGetByID(tama_id);

            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Tama>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpPost]
        [Route("")]
        public object Create(Tama tama)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();

            try
            {
                dataManager.TamaCreate(tama);
            }
            catch
            { 
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [HttpPost]
        [Route("{tama_id}")]
        public object Update(Guid tama_id, Tama tama)
        {
            if (tama_id != tama.tama_id)
            {
                throw new Exception("Identifier mistmatch.");
            }

            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.TamaUpdate(tama_id, tama);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("{tama_id}")]
        public object Delete(Guid tama_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.TamaDelete(tama_id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
