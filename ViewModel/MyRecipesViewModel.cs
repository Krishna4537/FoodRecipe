using System.Collections.ObjectModel;
using System.Diagnostics;
using FoodRecipe;
using Recipes.Services;
using FoodRecipe.ViewModels;
using System.Windows.Input;
//using FoodRecipe.Helpers;


namespace Recipes.ViewModels
{
    public class MyRecipesViewModel : BaseViewModel
    {
        public RecipeModel _selectedItem;
        private ObservableCollection<RecipeModel> _filteredRecipes;

        public ObservableCollection<RecipeModel> FilteredRecipes
        {
            get => _filteredRecipes;
            set => SetProperty(ref _filteredRecipes, value);
        }
    
        public ObservableCollection<RecipeModel> Items { get; set; }
        public Command LoadItemsCommand { get; }
        public Command NewRecipeCommand { get; }
        public Command<RecipeModel> ItemTapped { get; }

        public ICommand ToggleLikeCommand { get; }
        public MyRecipesViewModel()
        {
            Title = "Recipes";
            Items = new ObservableCollection<RecipeModel>(App._recipes);
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            FilterRecipes("");
            ItemTapped = new Command<RecipeModel>(OnItemSelected);
            ToggleLikeCommand = new Command<RecipeModel>(OnToggleLike);
            //NewRecipeCommand = new Command(OnNewRecipe);
        }

        //public async Task<ObservableCollection<RecipeModel>> fetchRecipes()
        //{
        //    App._recipes = await MyStorage.ReadDataAsync();
        //    return new ObservableCollection<RecipeModel>(App._recipes);
        //}
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                //foreach (var item in items)
                //{
                //    Items.Add(item);
                //}
                FilteredRecipes = new ObservableCollection<RecipeModel>(Items);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;

            LoadItemsCommand.Execute(null);
        }

        public RecipeModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        //private async void OnNewRecipe(object obj)
        //{
        //    await Shell.Current.GoToAsync(nameof(NewRecipePage));
        //}

        async void OnItemSelected(RecipeModel item)
        {
            if (item == null)
                return;

            // This will push the RecipeDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(RecipeDetailPage)}?{nameof(RecipeDetailViewModel.ItemId)}={item.Id}");
        }
        private void OnToggleLike(RecipeModel recipe)
        {
            recipe.IsLiked = !recipe.IsLiked;
            // You can add additional logic here (e.g., save the liked status to storage)
        }
        public void FilterRecipes(string searchText)
        {
            //, bool showLiked
            //var filteredList = Items;

            //if (!string.IsNullOrWhiteSpace(searchText))
            //{
            //    filteredList = new ObservableCollection<RecipeModel>(
            //        filteredList.Where(recipe => recipe.RecipeName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
            //    );
            //}

            //if (showLiked)
            //{
            //    filteredList = new ObservableCollection<RecipeModel>(
            //        filteredList.Where(recipe => recipe.IsLiked)
            //    );
            //}

            //FilteredRecipes = new ObservableCollection<RecipeModel>(filteredList);

            if (string.IsNullOrWhiteSpace(searchText))
            {
                FilteredRecipes = Items;
            }
            else
            {
                FilteredRecipes = new ObservableCollection<RecipeModel>(
                    Items.Where(recipe => recipe.RecipeName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                );
            }
        }
    }
}
