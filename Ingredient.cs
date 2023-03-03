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
        public Volume Volume { get; private set; }

        public Ingredient(string name, int unit, Volume volume)
        {
            Name = name;
            Unit = unit;
            Volume = volume;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\n" + "Unit: " + this.Unit + "\n" + "Volume: " + this.Volume;
        }
    }
}
