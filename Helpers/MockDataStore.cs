//// MockDataStore.cs
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using FoodRecipe;
//using Recipes.Services;


//namespace Recipes.Services
//{
//    public static class MockDataStore
//    {

//        public static List<RecipeModel> GetMockRecipes()
//        {
//            return new List<RecipeModel>()
//            {
//                new RecipeModel
//                {
//                    RecipeName = "Mushroom Matar Masala Recipe",
//                    ImageUrl = "https://www.archanaskitchen.com/images/archanaskitchen/1-Author/Pooja_Thakur/Karela_Masala_Recipe-4_1600.jpg",
//                    Ingredients = new List<IngredientModel>{
//                        new IngredientModel("1", "tablespoon", "Red Chilli powder"),
//                        new IngredientModel("3", "tablespoon", "Gram flour (besan)"),
//                        new IngredientModel("2", "tablespoon", "Cumin seeds"),
//                        new IngredientModel("1", "tablespoon", "Coriander Powder (Dhania)"),
//                        new IngredientModel("2", "tablespoon", "Turmeric powder (Haldi)"),
//                        new IngredientModel("2", "tablespoon", "Dry Mango Powder"),
//                        new IngredientModel("1", "quantity", "Onion - thinly sliced"),


//                    },
//                    TotalTimeInMins=65,
//                    Instructions = "1. Grab a bowl, and add the scallion (chopped), eggs (cracked), salt, pepper.\n" +
//                    "2. Thoroughly beat the egg mixture.\n" +
//                    "3. Heat the pan on the stove, and add 3 turns of oil.\n" +
//                    "4. Once pan is ready/warm, pour in the egg mixture; if using 8 eggs, pour in only half.\n" +
//                    "5. Tilt the pan around so egg mixture fills the pan.\n" +
//                    "6. Begin folding the egg over from the edge of the pan.\n" +
//                    "7. Continually fold egg over while pushing uncooked egg to the other side of the pan and shaping it.\n" +
//                    "8. Once completely folded, remove from pan.\n" +
//                    "9. Repeat steps 3 - 8 if there is remaining egg mixture.\n" +
//                    "10. Cut the ???? into pieces.",
//                },
//                new RecipeModel
//                {
//                    RecipeName = "Spicy Tomato Rice (Recipe)",
//                    ImageUrl = "https://www.archanaskitchen.com/images/archanaskitchen/1-Author/b.yojana-gmail.com/Spicy_Thakkali_Rice_Tomato_Pulihora-1_edited.jpg",
//                    Ingredients = new List<IngredientModel>{
//                        new IngredientModel("1", "tablespoon", "Red Chilli powder"),
//                        new IngredientModel("2", "tablespoon", "cashew - or peanuts"),
//                        new IngredientModel("1", "tablespoon", "white urad dal"),
//                        new IngredientModel("1", "tablespoon", "Cumin seeds"),

//                    },
//                    TotalTimeInMins=45,
//                    Instructions = "1. Pour water into the pot so that it fills about about 1/3 of the pot. Bring the water to a boil.\n" +
//                    "2. Put the bagged ?? into the pot.\n" +
//                    "3. 10 minutes later, add the ?? and ?? ?? into the pot.\n" +
//                    "4. Stir the ingredients in the soup mixture, as it continues to boil.\n" +
//                    "5. Add in the ????.\n" +
//                    "6. Add in the potato, carrots, onion chunks. These veggies should be chopped in advance into 1/2” - 1” pieces.\n" +
//                    "7. Add in any additional ingredients you have! (i.e. beef, tofu, etc.).\n" +
//                    "8. If you have, add in the Korean squash! This should also have been chopped in advance into 1/2” - 1” pieces.\n" +
//                    "9. Continue to boil until ready to serve. Use ladle to remove any froth floating on the soup’s surface",
//                },
//                new RecipeModel
//                {
//                    RecipeName = "Ragi Semiya Upma Recipe - Ragi Millet Vermicelli Breakfast",
//                    ImageUrl = "https://www.archanaskitchen.com/images/archanaskitchen/1-Author/Monika_Manchanda/Ragi_vermicilli.jpg",
//                    Ingredients = new List<IngredientModel>{
//                        new IngredientModel("1", "tablespoon", "Red Chilli powder"),
//                        new IngredientModel("500", "grams", "Vermicelli"),
//                        new IngredientModel("100", "grams", "Ragi"),
//                        new IngredientModel("1", "tablespoon", "Cumin seeds"),


//                    },
//                    TotalTimeInMins=55,
//                    Instructions = "1. Thaw frozen salmon for at least 2 hours.\n" +
//                    "2. Salt and pepper the salmon on both sides.\n" +
//                    "3. Oil the pan.\n" +
//                    "4. Place the seasoned salmon into the pan, covering the bottom with a single layer.\n" +
//                    "5. Mix masago, mayo, and scallion (chopped) together in a small bowl.\n" +
//                    "6. Spread a thin layer of the mixture onto the salmon.\n" +
//                    "7. Preheat the oven to 350ºF.\n" +
//                    "8. Cover the pan with foil and poke holes with a fork.\n" +
//                    "9. Bake the salmon! (combination fast bake ~30 minutes)",
//                },
//                new RecipeModel
//                {
//                    RecipeName = "Gongura Chicken Curry Recipe",
//                    ImageUrl = "https://www.archanaskitchen.com/images/archanaskitchen/Ghongura_Chicken_Curry_Recipe-2_1600.jpg",
//                    Ingredients = new List<IngredientModel>{
//                        new IngredientModel("1", "tablespoon", "Red Chilli powder"),
//                        new IngredientModel("500", "grams", "Vermicelli"),
//                        new IngredientModel("100", "grams", "Ragi"),
//                        new IngredientModel("1", "tablespoon", "Cumin seeds"),
//                        new IngredientModel("1", "kg", "chicken")


//                    },
//                    TotalTimeInMins=75,
//                    Instructions = "1. Thaw frozen chicken for at least 2 hours.\n" +
//                    "2. Salt and pepper the salmon on both sides.\n" +
//                    "3. Oil the pan.\n" +
//                    "4. Place the seasoned salmon into the pan, covering the bottom with a single layer.\n" +
//                    "5. Mix masago, mayo, and scallion (chopped) together in a small bowl.\n" +
//                    "6. Spread a thin layer of the mixture onto the salmon.\n" +
//                    "7. Preheat the oven to 350ºF.\n" +
//                    "8. Cover the pan with foil and poke holes with a fork.\n" +
//                    "9. Bake the salmon! (combination fast bake ~30 minutes)",
//                }
//            };
//        }

//    }
//}
