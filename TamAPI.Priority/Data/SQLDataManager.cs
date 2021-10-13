using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tam.API.Core;
using TamAPI.Models;
using TamAPI.Priority.Data;

namespace TamAPI.Data.Sql.Data
{
    public class SQLDataManager : IDataManager
    {
        public SQLDataManager(EntityFactory factory)
        {
            this.Factory = factory;
        }

        public EntityFactory Factory { get; set; }

        public Tama TamaGetByName(string name)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbTama other = (from t in db.dbTamas
                            where (name != null && t.tama_name.Contains(name))
                            select t).FirstOrDefault();

            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public Tama TamaGetByID(Guid tama_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbTama other = (from t in db.dbTamas
                            where t.tama_id == tama_id
                            select t).FirstOrDefault();

            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public void TamaCreate(Tama tama)
        {
            tamEntities db = this.Factory.CreateEntities();
            dbTama insert = tama.ToDbModel();
            db.dbTamas.Add(insert);
            db.SaveChanges();
        }

        public void TamaUpdate(Guid tama_id, Tama tama)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbTama other = (from t in db.dbTamas
                            where t.tama_id == tama_id
                            select t).FirstOrDefault();
            if (other != null)
            {
                other.tama_name = tama.tama_name;
                other.tama_age = tama.tama_age;
                other.tama_gender = tama.tama_gender;
                db.SaveChanges();
            }
        }

        public void TamaDelete(Guid tama_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbTama other = (from t in db.dbTamas
                            where t.tama_id == tama_id
                            select t).FirstOrDefault();
            if (other != null)
            {
                db.dbTamas.Remove(other);
                db.SaveChanges();
            }
        }

        public Snack SnackGetByName(string name = null)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbSnack other = (from t in db.dbSnacks
                             where (name != null && t.snack_name.Contains(name))
                             select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public Snack SnackGetbyID(Guid snack_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbSnack other = (from t in db.dbSnacks
                             where t.snack_id == snack_id
                             select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public void SnackCreate(Snack snack)
        {
            tamEntities db = this.Factory.CreateEntities();
            dbSnack insert = snack.ToDbModel();
            db.dbSnacks.Add(insert);
            db.SaveChanges();
        }

        public void SnackUpdate(Guid snack_id, Snack snack)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbSnack other = (from t in db.dbSnacks
                             where t.snack_id == snack_id
                             select t).FirstOrDefault();
            if (other != null)
            {
                other.snack_name = snack.snack_name;
                db.SaveChanges();
            }
        }

        public void SnackDelete(Guid snack_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbSnack other = (from t in db.dbSnacks
                             where t.snack_id == snack_id
                             select t).FirstOrDefault();
            if (other != null)
            {
                db.dbSnacks.Remove(other);
                db.SaveChanges();
            }
        }

        public OwnerSnack OwnerSnackGetbyID(Guid ownersnack_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbOwnerSnack other = (from t in db.dbOwnerSnacks
                                  where t.ownersnack_id == ownersnack_id
                                  select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public void OwnerSnackCreate(OwnerSnack ownersnack)
        {

            tamEntities db = this.Factory.CreateEntities();
            dbOwnerSnack insert = ownersnack.ToDbModel();
            db.dbOwnerSnacks.Add(insert);
            db.SaveChanges();
        }

        public void OwnerSnackUpdate(Guid ownersnack_id, OwnerSnack ownersnack)
        {

            tamEntities db = this.Factory.CreateEntities();

            dbOwnerSnack other = (from t in db.dbOwnerSnacks
                                  where t.ownersnack_id == ownersnack_id
                                  select t).FirstOrDefault();
            if (other != null)
            {
                other.snack_quantity = ownersnack.snack_quantity;
                db.SaveChanges();
            }
        }

        public void OwnerSnackDelete(Guid ownersnack_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbOwnerSnack other = (from t in db.dbOwnerSnacks
                                  where t.ownersnack_id == ownersnack_id
                                  select t).FirstOrDefault();
            if (other != null)
            {
                db.dbOwnerSnacks.Remove(other);
                db.SaveChanges();
            }
        }

        public OwnerFood OwnerFoodGetByID(Guid ownerfood_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbOwnerFood other = (from t in db.dbOwnerFoods
                                 where t.ownerfood_id == ownerfood_id
                                 select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public void OwnerFoodCreate(OwnerFood ownerfood)
        {
            tamEntities db = this.Factory.CreateEntities();
            dbOwnerFood insert = ownerfood.ToDbModel();
            db.dbOwnerFoods.Add(insert);
            db.SaveChanges();
        }

        public void OwnerFoodUpdate(Guid ownerfood_id, OwnerFood ownerfood)
        {

            tamEntities db = this.Factory.CreateEntities();

            dbOwnerFood other = (from t in db.dbOwnerFoods
                                 where t.ownerfood_id == ownerfood_id
                                 select t).FirstOrDefault();
            if (other != null)
            {
                other.food_quantity = ownerfood.food_quantity;
                db.SaveChanges();
            }
        }

        public void OwnerFoodDelete(Guid ownerfood_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbOwnerFood other = (from t in db.dbOwnerFoods
                                 where t.ownerfood_id == ownerfood_id
                                 select t).FirstOrDefault();
            if (other != null)
            {
                db.dbOwnerFoods.Remove(other);
                db.SaveChanges();
            }
        }

        public Owner OwnerGetByName(string name = null)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbOwner other = (from t in db.dbOwners
                             where (name != null && t.owner_name.Contains(name))
                             select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public Owner OwnerGetbyID(Guid owner_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbOwner other = (from t in db.dbOwners
                             where t.owner_id == owner_id
                             select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public void OwnerCreate(Owner owner)
        {
            tamEntities db = this.Factory.CreateEntities();
            dbOwner insert = owner.ToDbModel();
            db.dbOwners.Add(insert);
            db.SaveChanges();
        }

        public void OwnerUpdate(Guid owner_id, Owner owner)
        {

            tamEntities db = this.Factory.CreateEntities();

            dbOwner other = (from t in db.dbOwners
                             where t.owner_id == owner_id
                             select t).FirstOrDefault();
            if (other != null)
            {
                other.owner_name = owner.owner_name;
                other.owner_age = owner.owner_age;
                db.SaveChanges();
            }
        }

        public void OwnerDelete(Guid owner_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbOwner other = (from t in db.dbOwners
                             where t.owner_id == owner_id
                             select t).FirstOrDefault();
            if (other != null)
            {
                db.dbOwners.Remove(other);
                db.SaveChanges();
            }
        }

        public Hunger HungerGetByName(string name = null)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbHunger other = (from t in db.dbHungers
                              where (name != null && t.hunger_name.Contains(name))
                              select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public Hunger HungerGetbyID(Guid hunger_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbHunger other = (from t in db.dbHungers
                              where t.hunger_id == hunger_id
                              select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public void HungerCreate(Hunger hunger)
        {
            tamEntities db = this.Factory.CreateEntities();
            dbHunger insert = hunger.ToDbModel();
            db.dbHungers.Add(insert);
            db.SaveChanges();
        }

        public void HungerUpdate(Guid hunger_id, Hunger hunger)
        {

            tamEntities db = this.Factory.CreateEntities();

            dbHunger other = (from t in db.dbHungers
                              where t.hunger_id == hunger_id
                              select t).FirstOrDefault();
            if (other != null)
            {
                other.hunger_name = hunger.hunger_name;
                db.SaveChanges();
            }
        }

        public void HungerDelete(Guid hunger_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbHunger other = (from t in db.dbHungers
                              where t.hunger_id == hunger_id
                              select t).FirstOrDefault();
            if (other != null)
            {
                db.dbHungers.Remove(other);
                db.SaveChanges();
            }
        }

        public Health HealthGetByName(string name = null)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbHealth other = (from t in db.dbHealths
                              where (name != null && t.health_name.Contains(name))
                              select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public Health HealthGetbyID(Guid health_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbHealth other = (from t in db.dbHealths
                              where t.health_id == health_id
                              select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public void HealthCreate(Health health)
        {
           tamEntities db = new tamEntities();
            dbHealth insert = health.ToDbModel();
            db.dbHealths.Add(insert);
            db.SaveChanges();
        }

        public void HealthUpdate(Guid health_id, Health health)
        {
            if (health_id != health.health_id)
            {
                throw new Exception("Identifier mistmatch.");
            }

            tamEntities db = this.Factory.CreateEntities();

            dbHealth other = (from t in db.dbHealths
                              where t.health_id == health_id
                              select t).FirstOrDefault();
            if (other != null)
            {
                other.health_name = health.health_name;
                db.SaveChanges();
            }
        }

        public void HealthDelete(Guid health_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbHealth other = (from t in db.dbHealths
                              where t.health_id == health_id
                              select t).FirstOrDefault();
            if (other != null)
            {
                db.dbHealths.Remove(other);
                db.SaveChanges();
            }
        }

        public Happiness HappinessGetByName(string name = null)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbHappiness other = (from t in db.dbHappinesses
                                 where (name != null && t.happiness_name.Contains(name))
                                 select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public Happiness HappinessGetbyID(Guid happiness_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbHappiness other = (from t in db.dbHappinesses
                                 where t.happiness_id == happiness_id
                                 select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public void HappinessCreate(Happiness happiness)
        {

            tamEntities db = this.Factory.CreateEntities();
            dbHappiness insert = happiness.ToDbModel();
            db.dbHappinesses.Add(insert);
            db.SaveChanges();
        }

        public void HappinessUpdate(Guid happiness_id, Happiness happiness)
        {

            tamEntities db = this.Factory.CreateEntities();

            dbHappiness other = (from t in db.dbHappinesses
                                 where t.happiness_id == happiness_id
                                 select t).FirstOrDefault();
            if (other != null)
            {
                other.happiness_name = happiness.happiness_name;
                db.SaveChanges();
            }
        }

        public void HappinessDelete(Guid happiness_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbHappiness other = (from t in db.dbHappinesses
                                 where t.happiness_id == happiness_id
                                 select t).FirstOrDefault();
            if (other != null)
            {
                db.dbHappinesses.Remove(other);
                db.SaveChanges();
            }
        }

        public Food FoodGetByName(string name = null)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbFood other = (from t in db.dbFoods
                            where (name != null && t.food_name.Contains(name))
                            select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public Food FoodGetbyID(Guid food_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbFood other = (from t in db.dbFoods
                            where t.food_id == food_id
                            select t).FirstOrDefault();
            if (other == null)
            {
                return null;
            }
            else
            {
                return other.ToApiModel();
            }
        }

        public void FoodCreate(Food food)
        {
           
            tamEntities db = this.Factory.CreateEntities();
            dbFood insert = food.ToDbModel();
            db.dbFoods.Add(insert);
            db.SaveChanges();
        }

        public void FoodUpdate(Guid food_id, Food food)
        {

            tamEntities db = this.Factory.CreateEntities();

            dbFood other = (from t in db.dbFoods
                            where t.food_id == food_id
                            select t).FirstOrDefault();
            if (other != null)
            {
                other.food_name = food.food_name;
                db.SaveChanges();
            }
        }

        public void FoodDelete(Guid food_id)
        {
            tamEntities db = this.Factory.CreateEntities();

            dbFood other = (from t in db.dbFoods
                            where t.food_id == food_id
                            select t).FirstOrDefault();
            if (other != null)
            {
                db.dbFoods.Remove(other);
                db.SaveChanges();
            }
        }
    }
}