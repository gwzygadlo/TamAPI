using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamAPI.Models;

namespace TamAPI.Priority.Data
{
    public class MockDataManager : IDataManager
    {
        public void FoodCreate(Food food)
        {
            throw new NotImplementedException();
        }

        public void FoodDelete(Guid food_id)
        {
            throw new NotImplementedException();
        }

        public Food FoodGetbyID(Guid food_id)
        {
            throw new NotImplementedException();
        }

        public Food FoodGetByName(string name = null)
        {
            return new Food() { food_name = "test_1" };
        }

        public void FoodUpdate(Guid food_id, Food food)
        {
            throw new NotImplementedException();
        }

        public void HappinessCreate(Happiness happiness)
        {
            throw new NotImplementedException();
        }

        public void HappinessDelete(Guid happiness_id)
        {
            throw new NotImplementedException();
        }

        public Happiness HappinessGetbyID(Guid happiness_id)
        {
            throw new NotImplementedException();
        }

        public Happiness HappinessGetByName(string name = null)
        {
            throw new NotImplementedException();
        }

        public void HappinessUpdate(Guid happiness_id, Happiness happiness)
        {
            throw new NotImplementedException();
        }

        public void HealthCreate(Health health)
        {
            throw new NotImplementedException();
        }

        public void HealthDelete(Guid health_id)
        {
            throw new NotImplementedException();
        }

        public Health HealthGetbyID(Guid health_id)
        {
            throw new NotImplementedException();
        }

        public Health HealthGetByName(string name = null)
        {
            throw new NotImplementedException();
        }

        public void HealthUpdate(Guid health_id, Health health)
        {
            throw new NotImplementedException();
        }

        public void HungerCreate(Hunger hunger)
        {
            throw new NotImplementedException();
        }

        public void HungerDelete(Guid hunger_id)
        {
            throw new NotImplementedException();
        }

        public Hunger HungerGetbyID(Guid hunger_id)
        {
            throw new NotImplementedException();
        }

        public Hunger HungerGetByName(string name = null)
        {
            throw new NotImplementedException();
        }

        public void HungerUpdate(Guid hunger_id, Hunger hunger)
        {
            throw new NotImplementedException();
        }

        public void OwnerCreate(Owner owner)
        {
            throw new NotImplementedException();
        }

        public void OwnerDelete(Guid owner_id)
        {
            throw new NotImplementedException();
        }

        public void OwnerFoodCreate(OwnerFood ownerfood)
        {
            throw new NotImplementedException();
        }

        public void OwnerFoodDelete(Guid ownerfood_id)
        {
            throw new NotImplementedException();
        }

        public OwnerFood OwnerFoodGetByID(Guid ownerfood_id)
        {
            throw new NotImplementedException();
        }

        public void OwnerFoodUpdate(Guid ownerfood_id, OwnerFood ownerfood)
        {
            throw new NotImplementedException();
        }

        public Owner OwnerGetbyID(Guid owner_id)
        {
            throw new NotImplementedException();
        }

        public Owner OwnerGetByName(string name = null)
        {
            throw new NotImplementedException();
        }

        public void OwnerSnackCreate(OwnerSnack ownersnack)
        {
            throw new NotImplementedException();
        }

        public void OwnerSnackDelete(Guid ownersnack_id)
        {
            throw new NotImplementedException();
        }

        public OwnerSnack OwnerSnackGetbyID(Guid ownersnack_id)
        {
            throw new NotImplementedException();
        }

        public void OwnerSnackUpdate(Guid ownersnack_id, OwnerSnack ownersnack)
        {
            throw new NotImplementedException();
        }

        public void OwnerUpdate(Guid owner_id, Owner owner)
        {
            throw new NotImplementedException();
        }

        public void SnackCreate(Snack snack)
        {
            throw new NotImplementedException();
        }

        public void SnackDelete(Guid snack_id)
        {
            throw new NotImplementedException();
        }

        public Snack SnackGetbyID(Guid snack_id)
        {
            throw new NotImplementedException();
        }

        public Snack SnackGetByName(string name = null)
        {
            throw new NotImplementedException();
        }

        public void SnackUpdate(Guid snack_id, Snack snack)
        {
            throw new NotImplementedException();
        }

        public void TamaCreate(Tama tama)
        {
            throw new NotImplementedException();
        }

        public void TamaDelete(Guid tama_id)
        {
            throw new NotImplementedException();
        }

        public Tama TamaGetByID(Guid tama_id)
        {
            throw new NotImplementedException();
        }

        public Tama TamaGetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TamaUpdate(Guid tama_id, Tama tama)
        {
            throw new NotImplementedException();
        }
    }
}
