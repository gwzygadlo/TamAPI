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
    [RoutePrefix("api/food")]
    public class FoodController : ApiController
    {
        public FoodController()
        {
            this.PrimaryFactory = new PrimaryFactory();
        }

        public PrimaryFactory PrimaryFactory { get; set; }
        [HttpGet]
        [Route("")]
        public object GetByName(string name = null)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Food other = dataManager.FoodGetByName(name);
            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Food>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpGet]
        [Route("{food_id}")]
        public object GetbyID(Guid food_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            Food other = dataManager.FoodGetbyID(food_id);

            if (other == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                return new DataEnvelope<Food>()
                {
                    item = other,
                    success = true
                };
            }
        }

        [HttpPost]
        [Route("")]
        public object Create(Food food)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();

            try
            {
                dataManager.FoodCreate(food);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [HttpPost]
        [Route("{food_id}")]
        public object Update(Guid food_id, Food food)
        {
            if (food_id != food.food_id)
            {
                throw new Exception("Identifier mistmatch.");
            }
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.FoodUpdate(food_id, food);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("{food_id}")]
        public object Delete(Guid food_id)
        {
            IDataManager dataManager = PrimaryFactory.CreateDataManager();
            dataManager.FoodDelete(food_id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
