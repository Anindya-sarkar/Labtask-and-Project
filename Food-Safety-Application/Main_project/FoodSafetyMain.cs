using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_project
{
    // Parent Class: Holds common primary key property for all entities
    public class FoodSafetyEntity
    {
        public int ID { get; set; }

        // Default Constructor
        public FoodSafetyEntity()
        {
        }

        // Parameterized Constructor
        public FoodSafetyEntity(int id)
        {
            this.ID = id;
        }
    }
}
