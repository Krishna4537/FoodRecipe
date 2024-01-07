using Recipes.ViewModels;
using FoodRecipe.Pages;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace FoodRecipe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MyRecipesViewModel MyRecipesViewModel { get; set; }  
        public MainPage()
        {
            InitializeComponent();
            BindingContext = MyRecipesViewModel = new MyRecipesViewModel();
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // Filter the recipes based on the search text  LikedRecipesSwitch.IsToggled
            MyRecipesViewModel.FilterRecipes(e.NewTextValue);
        }

        //private void OnLikedRecipesToggled(object sender, ToggledEventArgs e)
        //{
        //    MyRecipesViewModel.FilterRecipes(SearchBar.Text, e.Value);
        //}

        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            Debug.WriteLine("On Navigated To: MainPage");
            App._recipes = await MyStorage.ReadEmbeddedXML<List<RecipeModel>>("output_file.xml");
            MyRecipesViewModel.Items = new ObservableCollection<RecipeModel>(App._recipes);
            MyRecipesViewModel.FilterRecipes("");
        }
        protected override async void OnAppearing()
        {
            //myRecipesViewModel.Items = await myRecipesViewModel.fetchRecipes();

            base.OnAppearing();

            //((MyRecipesViewModel)BindingContext).OnAppearing();
        }
        private void OnRecipeSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is RecipeModel selectedRecipe)
            {
                Navigation.PushAsync(new RecipeDetailPage(selectedRecipe));
            }
        }

     }

}
