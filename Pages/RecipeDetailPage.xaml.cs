
using Recipes.ViewModels;
using FoodRecipe.Pages;
using FoodRecipe;

namespace FoodRecipe.Pages;

public partial class RecipeDetailPage : ContentPage
{
    private RecipeDetailViewModel viewModel;
    public RecipeDetailPage(RecipeModel selectedRecipe)
    {
        InitializeComponent();

        // Create an instance of the ViewModel and set it as the BindingContext
        viewModel = new RecipeDetailViewModel(selectedRecipe);
        BindingContext = viewModel;
    }

    private async void OnGenerateShoppingListClicked(object sender, EventArgs e)
    {
        App._cartIngredients = new List<IngredientModel>(viewModel.SelectedRecipe.Ingredients);
        await Navigation.PushAsync(new ShoppingList());
    }

    private void ServingsEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(((Entry)sender).Text != "")
        {
            var servings = decimal.Parse(((Entry)sender).Text);

            if (servings > 0)
            {
                IngredientsList.ItemsSource = viewModel.UpdateIngredientServings(servings);
            }

        }
    }
}