
using FoodRecipe.Pages;

namespace FoodRecipe
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RecipeDetailPage), typeof(RecipeDetailPage));
            RegisterRoutes();
        }
        void RegisterRoutes()
        {
            //Routing.RegisterRoute(nameof(FavoritesPage), typeof(Favorites));
            //Routing.RegisterRoute(nameof(ShoppingList), typeof(ShoppingList));
            //Routing.RegisterRoute(nameof(Settings), typeof(Settings));
        }
    }
}
