using FoodRecipe;
using Recipes.Services;

namespace FoodRecipe
{
    public partial class App : Application
    {
        public static List<RecipeModel> _recipes { get; set; }
        public static List<IngredientModel> _cartIngredients { get; set; }
        public App()
        {
            //_recipes = await MyStorage.ReadEmbeddedXML<List<RecipeModel>>("output_file.xml");
            _cartIngredients = new List<IngredientModel>();
            _recipes = new List<RecipeModel>();
            //_recipes = new List<RecipeModel>();
            Task.Run(async () =>
            {
                //_recipes = await MyStorage.ReadDataAsync();
                //App._recipes = await MyStorage.ReadEmbeddedXML<List<RecipeModel>>("output_file.xml");
            });

            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
