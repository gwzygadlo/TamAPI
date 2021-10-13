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
    [RoutePrefix("api/owner")]
    public class OwnerController : ApiController
    {
        public OwnerController()
        {
            this.PrimaryFactory = new PrimaryFactory();
        }

        public PrimaryFactory PrimaryFactory { get; set; }
        [HttpGet]
        [Route("")]
        public object GetByName(string name = null)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Owner other = dataManager.OwnerGetByName(name);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Owner>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpGet]
        [Route("{owner_id}")]
        public object GetbyID(Guid owner_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Owner other = dataManager.OwnerGetbyID(owner_id);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Owner>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpPost]
        [Route("")]
        public object Create(Owner owner)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();

            try
            {
                dataManager.OwnerCreate(owner);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [HttpPost]
        [Route("{owner_id}")]
        public object Update(Guid owner_id, Owner owner)
        {
            if (owner_id != owner.owner_id)
            {
                throw new Exception("Identifier mistmatch.");
            }

            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.OwnerUpdate(owner_id, owner);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("{owner_id}")]
        public object Delete(Guid owner_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.OwnerDelete(owner_id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
