using System;

namespace Main_project.Models
{
    
    public abstract class FoodSafetyEntity
    {
        public int ID { get; set; }

        protected FoodSafetyEntity() { }

        protected FoodSafetyEntity(int id)
        {
            this.ID = id;
        }
    }
}
