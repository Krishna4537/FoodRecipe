
using Recipes.ViewModels;
namespace FoodRecipe.Pages;


public partial class ShoppingList : ContentPage
{
    public ShoppingList()
    {
        InitializeComponent();
        BindingContext = new ShoppingListViewModel(App._cartIngredients);
    }
}