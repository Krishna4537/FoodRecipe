//// RecipeService.cs
//using FoodRecipe;
//using System.Collections.Generic;
//using System.IO;
//using System.Xml.Linq;

//namespace FoodRecipe {
//    public static class RecipeService
//    {
//        public static List<RecipeModel> GetRecipes()
//        {
//            List<RecipeModel> recipes = new List<RecipeModel>();

//            var xmlPath = "FoodRecipe.Resources.Raw.recipelist.xml";
//            var assembly = typeof(RecipeService).Assembly;

//            using (Stream stream = assembly.GetManifestResourceStream(xmlPath))
//            {
//                if (stream != null)
//                {
//                    XDocument doc = XDocument.Load(stream);

//                    foreach (var recipeElement in doc.Descendants("Recipe"))
//                    {
//                        RecipeModel recipe = new RecipeModel
//                        {
//                            RecipeName = recipeElement.Element("RecipeName")?.Value,
//                            Ingredients = recipeElement.Element("Ingredients")?.Elements("Ingredient").Select(e => e.Value).ToList(),
//                            TotalTimeInMins = int.Parse(recipeElement.Element("TotalTimeInMins")?.Value),
//                            Instructions = recipeElement.Element("Instructions")?.Value,
//                            ImageUrl = recipeElement.Element("Image-url")?.Value,
//                            IngredientCount = int.Parse(recipeElement.Element("Ingredient-count")?.Value)
//                        };

//                        recipes.Add(recipe);
//                    }
//                }
//            }

//            return recipes;
//        }
//    }
//}
