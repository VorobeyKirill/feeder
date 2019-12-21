using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class FeederEntity : BaseEntity
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Interval { get; set; }
        public int FoodAmount { get; set; }

        public FeederEntity()
        {
        }

        public FeederEntity(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
