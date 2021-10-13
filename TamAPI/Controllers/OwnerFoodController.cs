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
    [RoutePrefix("api/ownerfood")]
    public class OwnerFoodController : ApiController
    {
        public OwnerFoodController()
        {
            this.PrimaryFactory = new PrimaryFactory();
        }

        public PrimaryFactory PrimaryFactory { get; set; }

        [HttpGet]
        [Route("{ownerfood_id}")]
        public object GetbyID(Guid ownerfood_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            OwnerFood other = dataManager.OwnerFoodGetByID(ownerfood_id);

            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<OwnerFood>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpPost]
        [Route("")]
        public object Create(OwnerFood ownerfood)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();

            try
            {
                dataManager.OwnerFoodCreate(ownerfood);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [HttpPost]
        [Route("{ownerfood_id}")]
        public object Update(Guid ownerfood_id, OwnerFood ownerfood)
        {
            if (ownerfood_id != ownerfood.ownerfood_id)
            {
                throw new Exception("Identifier mistmatch.");
            }

            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.OwnerFoodUpdate(ownerfood_id, ownerfood);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("{ownerfood_id}")]
        public object Delete(Guid ownerfood_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.TamaDelete(ownerfood_id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
