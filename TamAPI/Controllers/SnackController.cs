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
    [RoutePrefix("api/snack")]
    public class SnackController : ApiController
    {
        public SnackController()
        {
            this.PrimaryFactory = new PrimaryFactory();
        }

        public PrimaryFactory PrimaryFactory { get; set; }

        [HttpGet]
        [Route("")]
        public object GetByName(string name = null)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Snack other = dataManager.SnackGetByName(name);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Snack>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpGet]
        [Route("{snack_id}")]
        public object GetbyID(Guid snack_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Snack other = dataManager.SnackGetbyID(snack_id);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Snack>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpPost]
        [Route("")]
        public object Create(Snack snack)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();

            try
            {
                dataManager.SnackCreate(snack);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [HttpPost]
        [Route("{snack_id}")]
        public object Update(Guid snack_id, Snack snack)
        {
            if (snack_id != snack.snack_id)
            {
                throw new Exception("Identifier mistmatch.");
            }

            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.SnackUpdate(snack_id, snack);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("{snack_id}")]
        public object Delete(Guid snack_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.SnackDelete(snack_id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
