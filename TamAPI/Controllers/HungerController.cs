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
    [RoutePrefix("api/hunger")]
    public class HungerController : ApiController
    {
        public HungerController()
        {
            this.PrimaryFactory = new PrimaryFactory();
        }

        public PrimaryFactory PrimaryFactory { get; set; }

        [HttpGet]
        [Route("")]
        public object GetByName(string name = null)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Hunger other = dataManager.HungerGetByName(name);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Hunger>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpGet]
        [Route("{hunger_id}")]
        public object GetbyID(Guid hunger_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Hunger other = dataManager.HungerGetbyID(hunger_id);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Hunger>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpPost]
        [Route("")]
        public object Create(Hunger hunger)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();

            try
            {
                dataManager.HungerCreate(hunger);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [HttpPost]
        [Route("{hunger_id}")]
        public object Update(Guid hunger_id, Hunger hunger)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.HungerUpdate(hunger_id, hunger);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("{hunger_id}")]
        public object Delete(Guid hunger_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.HungerDelete(hunger_id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
