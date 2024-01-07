using System.Collections.ObjectModel;
using System.Diagnostics;
using FoodRecipe;
using Recipes.Services;
using FoodRecipe.ViewModels;
//using FoodRecipe.Helpers;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Recipes.ViewModels
{
    public class ShoppingListViewModel : BaseViewModel
    {
        private List<IngredientModel> _shoppingList;

        public List<IngredientModel> ShoppingList
        {
            get { return _shoppingList; }
            set
            {
                if (_shoppingList != value)
                {
                    _shoppingList = value;
                    OnPropertyChanged();
                }
            }
        }

        public ShoppingListViewModel(List<IngredientModel> shoppingList)
        {
            ShoppingList = shoppingList;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
