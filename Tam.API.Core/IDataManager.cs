using System;
using TamAPI.Models;

namespace TamAPI.Priority.Data
{
    public interface IDataManager
    {
        Tama TamaGetByName(string name);

        Tama TamaGetByID(Guid tama_id);

        void TamaCreate(Tama tama);

        void TamaUpdate(Guid tama_id, Tama tama);

        void TamaDelete(Guid tama_id);

        Snack SnackGetByName(string name = null);

        Snack SnackGetbyID(Guid snack_id);

        void SnackCreate(Snack snack);

        void SnackUpdate(Guid snack_id, Snack snack);

        void SnackDelete(Guid snack_id);

        OwnerSnack OwnerSnackGetbyID(Guid ownersnack_id);

        void OwnerSnackCreate(OwnerSnack ownersnack);

        void OwnerSnackUpdate(Guid ownersnack_id, OwnerSnack ownersnack);

        void OwnerSnackDelete(Guid ownersnack_id);

        OwnerFood OwnerFoodGetByID(Guid ownerfood_id);

        void OwnerFoodCreate(OwnerFood ownerfood);

        void OwnerFoodUpdate(Guid ownerfood_id, OwnerFood ownerfood);

        void OwnerFoodDelete(Guid ownerfood_id);

        Owner OwnerGetByName(string name = null);

        Owner OwnerGetbyID(Guid owner_id);

        void OwnerCreate(Owner owner);

        void OwnerUpdate(Guid owner_id, Owner owner);

        void OwnerDelete(Guid owner_id);

        Hunger HungerGetByName(string name = null);

        Hunger HungerGetbyID(Guid hunger_id);

        void HungerCreate(Hunger hunger);

        void HungerUpdate(Guid hunger_id, Hunger hunger);

        void HungerDelete(Guid hunger_id);

        Health HealthGetByName(string name = null);

        Health HealthGetbyID(Guid health_id);

        void HealthCreate(Health health);

        void HealthUpdate(Guid health_id, Health health);

        void HealthDelete(Guid health_id);

        Happiness HappinessGetByName(string name = null);

        Happiness HappinessGetbyID(Guid happiness_id);

        void HappinessCreate(Happiness happiness);

        void HappinessUpdate(Guid happiness_id, Happiness happiness);

        void HappinessDelete(Guid happiness_id);

        Food FoodGetByName(string name = null);

        Food FoodGetbyID(Guid food_id);

        void FoodCreate(Food food);

        void FoodUpdate(Guid food_id, Food food);

        void FoodDelete(Guid food_id);
    }
}
