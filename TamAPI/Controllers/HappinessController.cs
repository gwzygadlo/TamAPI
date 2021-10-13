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
    [RoutePrefix("api/happiness")]
    public class HappinessController : ApiController
    {
        public HappinessController()
        {
            this.PrimaryFactory = new PrimaryFactory();
        }

        public PrimaryFactory PrimaryFactory { get; set; }

        [HttpGet]
        [Route("")]
        public object GetByName(string name = null)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Happiness other = dataManager.HappinessGetByName(name);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Happiness>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpGet]
        [Route("{happiness_id}")]
        public object GetbyID(Guid happiness_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Happiness other = dataManager.HappinessGetbyID(happiness_id);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Happiness>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpPost]
        [Route("")]
        public object Create(Happiness happiness)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();

            try
            {
                dataManager.HappinessCreate(happiness);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [HttpPost]
        [Route("{happiness_id}")]
        public object Update(Guid happiness_id, Happiness happiness)
        {
            if (happiness_id != happiness.happiness_id)
            {
                throw new Exception("Identifier mistmatch.");
            }

            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.HappinessUpdate(happiness_id, happiness);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("{happiness_id}")]
        public object Delete(Guid happiness_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.HappinessDelete(happiness_id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
