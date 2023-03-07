using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingRecipe
{
    public class Ingredient
    {
        //Enum: tsp,tbsp,fl_oz,c,pt,qt,gal
        public string Name { get; private set; }
        public int Unit { get; private set; }
        public Measurement Measurement { get; private set; }

        public Ingredient(string name, int unit, Measurement measurement)
        {
            this.Name = name;
            this.Unit = unit;
            this.Measurement = measurement;
        }
    }
}
