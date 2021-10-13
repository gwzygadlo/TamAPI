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
    [RoutePrefix("api/health")]
    public class HealthController : ApiController
    {
        public HealthController()
        {
            this.PrimaryFactory = new PrimaryFactory();
        }

        public PrimaryFactory PrimaryFactory { get; set; }

        [HttpGet]
        [Route("")]
        public object GetByName(string name = null)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Health other = dataManager.HealthGetByName(name);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Health>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpGet]
        [Route("{health_id}")]
        public object GetbyID(Guid health_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Health other = dataManager.HealthGetbyID(health_id);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Health>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpPost]
        [Route("")]
        public object Create(Health health)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();

            try
            {
                dataManager.HealthCreate(health);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [HttpPost]
        [Route("{health_id}")]
        public object Update(Guid health_id, Health health)
        {
            if (health_id != health.health_id)
            {
                throw new Exception("Identifier mistmatch.");
            }

            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.HealthUpdate(health_id, health);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("{health_id}")]
        public object Delete(Guid health_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.HealthDelete(health_id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }


    }
}
