using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    public class Recipe
    {
        private string treatedDisease;
        private string instructions;
        private List<Herb> ingredients;

        public String TreatedDisease
        {
            get { return treatedDisease; }
            set { treatedDisease = value; }
        }
        public System.String Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }
        public List<Herb> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public Recipe() { }
        public Recipe(String treatedDisease, string instructions, List<Herb> ingridients)
        {
            TreatedDisease = treatedDisease;
            Instructions = instructions;
            Ingredients = ingridients;
        }

        public static List<Recipe> SearchByTreatedDisease(List<Recipe> recipes, string treatedDisease)
        {
            return recipes
                .Where(recipe => recipe.TreatedDisease.Trim().ToLower()
                .Contains(treatedDisease.Trim().ToLower()))
                .ToList();
        }

        public static List<Recipe> SearchByHerb(List<Recipe> recipes, string herbName)
        {
            return recipes.Where(recipe =>
                recipe.Ingredients.Any(herb =>
                    herb.Name.IndexOf(herbName, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();
        }

        public override string ToString()
        {
            return "Рецепт от " + TreatedDisease;
        }
    }
}
