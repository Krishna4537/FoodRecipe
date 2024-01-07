using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FoodRecipe
{
    public class RecipeModel
    {
        public string? RecipeName { get; set; }
        public List<IngredientModel> Ingredients { get; set; }
        public int TotalTimeInMins { get; set; }
        public string? Instructions { get; set; }
        public string? ImageUrl { get; set; }
        public int IngredientCount { get; set; }

        public bool IsLiked { get; set; }

        public RecipeModel()
        {
            IsLiked = false; 
        }

    }

}
