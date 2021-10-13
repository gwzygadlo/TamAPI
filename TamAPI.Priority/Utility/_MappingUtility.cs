using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamAPI.Models;

namespace TamAPI.Data.Sql.Data
{
    public static class _MappingUtility
    {
        public static Tama ToApiModel(this dbTama other)
        {
            if (other == null)
            {
                return null;
            }
            else
            {
                return new Tama()
                {
                    tama_name = other.tama_name,
                    tama_gender = other.tama_gender,
                    tama_age = other.tama_age,
                    tama_type = other.tama_type,
                    tama_id = other.tama_id,
                    owner_id = other.owner_id,
                    health_id = other.health_id,
                    hunger_id = other.hunger_id,
                    happiness_id = other.happiness_id,
                };
            }
        }

        public static dbTama ToDbModel(this Tama tama)
        {
            if (tama == null)
            {
                return null;
            }
            else
            {
                return new dbTama()
                {
                    tama_name = tama.tama_name,
                    tama_gender = tama.tama_gender,
                    tama_age = tama.tama_age,
                    tama_type = tama.tama_type,
                    tama_id = tama.tama_id,
                    owner_id = tama.owner_id,
                    health_id = tama.health_id,
                    hunger_id = tama.hunger_id,
                    happiness_id = tama.happiness_id,
                };
            }
        }

        public static Owner ToApiModel(this dbOwner other)
        {
            if (other == null)
            {
                return null;
            }
            else
            {
                return new Owner()
                {
                    owner_name = other.owner_name,
                    owner_id = other.owner_id,
                    owner_points = other.owner_points,
                    owner_age = other.owner_age
                };
            }
        }

        public static dbOwner ToDbModel(this Owner owner)
        {
            if (owner == null)
            {
                return null;
            }
            else
            {
                return new dbOwner()
                {
                    owner_name = owner.owner_name,
                    owner_id = owner.owner_id,
                    owner_age = owner.owner_age,
                    owner_points = owner.owner_points
                };
            }
        }

        public static Snack ToApiModel(this dbSnack other)
        {
            if (other == null)
            {
                return null;
            }
            else
            {
                return new Snack()
                {
                    snack_name = other.snack_name,
                    snack_id = other.snack_id,
                    cost = other.cost,
                };
            }
        }

        public static dbSnack ToDbModel(this Snack snack)
        {
            if (snack == null)
            {
                return null;
            }
            else
            {
                return new dbSnack()
                {
                    snack_name = snack.snack_name,
                    snack_id = snack.snack_id,
                    cost = snack.cost,
                };
            }
        }

        public static Food ToApiModel(this dbFood other)
        {
            if (other == null)
            {
                return null;
            }
            else
            {
                return new Food()
                {
                    food_name = other.food_name,
                    food_id = other.food_id,
                    cost = other.cost,
                };
            }
        }

        public static dbFood ToDbModel(this Food food)
        {
            if (food == null)
            {
                return null;
            }
            else
            {
                return new dbFood()
                {
                    food_name = food.food_name,
                    food_id = food.food_id,
                    cost = food.cost,
                };
            }
        }

        public static Health ToApiModel(this dbHealth other)
        {
            if (other == null)
            {
                return null;
            }
            else
            {
                return new Health()
                {
                    health_name = other.health_name,
                    health_id = other.health_id,
                    health_scale = other.health_scale
                };
            }
        }

        public static dbHealth ToDbModel(this Health health)
        {
            if (health == null)
            {
                return null;
            }
            else
            {
                return new dbHealth()
                {
                    health_name = health.health_name,
                    health_id = health.health_id,
                    health_scale = health.health_scale,
                };
            }
        }

        public static Happiness ToApiModel(this dbHappiness other)
        {
            if (other == null)
            {
                return null;
            }
            else
            {
                return new Happiness()
                {
                    happiness_name = other.happiness_name,
                    happiness_id = other.happiness_id,
                    happiness_scale = other.happiness_scale
                };
            }
        }

        public static dbHappiness ToDbModel(this Happiness happiness)
        {
            if (happiness == null)
            {
                return null;
            }
            else
            {
                return new dbHappiness()
                {
                    happiness_name = happiness.happiness_name,
                    happiness_id = happiness.happiness_id,
                    happiness_scale = happiness.happiness_scale,
                };
            }
        }

        public static Hunger ToApiModel(this dbHunger other)
        {
            if (other == null)
            {
                return null;
            }
            else
            {
                return new Hunger()
                {
                    hunger_name = other.hunger_name,
                    hunger_id = other.hunger_id,
                    hunger_scale = other.hunger_scale
                };
            }
        }

        public static dbHunger ToDbModel(this Hunger hunger)
        {
            if (hunger == null)
            {
                return null;
            }
            else
            {
                return new dbHunger()
                {
                    hunger_name = hunger.hunger_name,
                    hunger_id = hunger.hunger_id,
                    hunger_scale = hunger.hunger_scale,
                };
            }
        }

        public static OwnerSnack ToApiModel(this dbOwnerSnack other)
        {
            if (other == null)
            {
                return null;
            }
            else
            {
                return new OwnerSnack()
                {
                    snack_quantity = other.snack_quantity,
                    ownersnack_id = other.ownersnack_id,
                    owner_id = other.owner_id,
                    snack_id = other.snack_id
                };
            }
        }

        public static dbOwnerSnack ToDbModel(this OwnerSnack ownersnack)
        {
            if (ownersnack == null)
            {
                return null;
            }
            else
            {
                return new dbOwnerSnack()
                {
                    snack_quantity = ownersnack.snack_quantity,
                    ownersnack_id = ownersnack.ownersnack_id,
                    snack_id = ownersnack.snack_id,
                    owner_id = ownersnack.owner_id
                };
            }
        }

        public static OwnerFood ToApiModel(this dbOwnerFood other)
        {
            if (other == null)
            {
                return null;
            }
            else
            {
                return new OwnerFood()
                {
                    food_quantity = other.food_quantity,
                    ownerfood_id = other.ownerfood_id,
                    owner_id = other.owner_id,
                    food_id = other.food_id
                };
            }
        }

        public static dbOwnerFood ToDbModel(this OwnerFood ownerfood)
        {
            if (ownerfood == null)
            {
                return null;
            }
            else
            {
                return new dbOwnerFood()
                {
                    food_quantity = ownerfood.food_quantity,
                    ownerfood_id = ownerfood.ownerfood_id,
                    food_id = ownerfood.food_id,
                    owner_id = ownerfood.owner_id
                };
            }
        }
    }
}