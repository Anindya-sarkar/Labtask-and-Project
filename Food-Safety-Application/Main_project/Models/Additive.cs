using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_project.Models
{
    // Inherits ID from FoodSafetyEntity
    public class Additive : FoodSafetyEntity
    {
        public string AdditiveName { get; set; }
        public string Category { get; set; }
        public string INSNumber { get; set; }
        public string MaxLimit { get; set; }
        public string RiskInfo { get; set; }

        public Additive() : base() { }

        public Additive(int id, string additiveName, string category, string insNumber, string maxLimit, string riskInfo) : base(id)
        {
            this.AdditiveName = additiveName;
            this.Category = category;
            this.INSNumber = insNumber;
            this.MaxLimit = maxLimit;
            this.RiskInfo = riskInfo;
        }
    }
}
