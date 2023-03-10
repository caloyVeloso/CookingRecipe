using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingRecipe
{
    public  class Dessert:Recipe
    {
        public Temperature Temperature { get; private set; }    

        public Dessert(string name, List<Ingredient> ingredients, int servingSize,Difficulty difficulty, List<string> procedure,Temperature temperature):
            base(name, ingredients, servingSize, difficulty, procedure)
        { 
            this.Temperature = temperature;
        }
    }
}
