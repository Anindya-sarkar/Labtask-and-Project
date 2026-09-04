using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_project.Models
{
    // Inherits ID from FoodSafetyEntity
    public class Food : FoodSafetyEntity
    {
        public string FoodName { get; set; }
        public string Category { get; set; }
        public string SafetyStatus { get; set; }

        public Food() : base() { }

        public Food(int id, string foodName, string category, string safetyStatus) : base(id)
        {
            this.FoodName = foodName;
            this.Category = category;
            this.SafetyStatus = safetyStatus;
        }
    }
}
