using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TamAPI.Data;
using TamAPI.Models;
using TamAPI.Data.Sql.Data;
using TamAPI.Priority.Data;
using Tam.API.Core;

namespace TamAPI.Controllers
{
    [RoutePrefix("api/ownersnack")]
    public class OwnerSnackController : ApiController
    {
        public OwnerSnackController()
        {
            this.PrimaryFactory = new PrimaryFactory();
        }

        public PrimaryFactory PrimaryFactory { get; set; }

        [HttpGet]
        [Route("{ownersnack_id}")]
        public object GetbyID(Guid ownersnack_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            OwnerSnack other = dataManager.OwnerSnackGetbyID(ownersnack_id);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<OwnerSnack>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpPost]
        [Route("")]
        public object Create(OwnerSnack ownersnack)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();

            try
            {
                dataManager.OwnerSnackCreate(ownersnack);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [HttpPost]
        [Route("{ownersnack_id}")]
        public object Update(Guid ownersnack_id, OwnerSnack ownersnack)
        {
            if (ownersnack_id != ownersnack.ownersnack_id)
            {
                throw new Exception("Identifier mistmatch.");
            }

            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.OwnerSnackUpdate(ownersnack_id, ownersnack);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("{ownersnack_id}")]
        public object Delete(Guid ownersnack_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.OwnerSnackDelete(ownersnack_id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
