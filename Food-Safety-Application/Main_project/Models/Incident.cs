using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_project.Models
{
    // Inherits ID from FoodSafetyEntity
    public class Incident : FoodSafetyEntity
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public string IncidentDate { get; set; }
        public string FoodCategory { get; set; }
        public string ViolationType { get; set; }
        public string Status { get; set; }

        public Incident() : base() { }

        public Incident(int id, string title, string location, string incidentDate, string foodCategory, string violationType, string status) : base(id)
        {
            this.Title = title;
            this.Location = location;
            this.IncidentDate = incidentDate;
            this.FoodCategory = foodCategory;
            this.ViolationType = violationType;
            this.Status = status;
        }
    }
}
