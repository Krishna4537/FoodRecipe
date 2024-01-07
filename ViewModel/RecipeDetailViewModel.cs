using System.Collections.ObjectModel;
using System.Diagnostics;
using FoodRecipe;
using Recipes.Services;
using FoodRecipe.ViewModels;
//using FoodRecipe.Helpers;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;


namespace Recipes.ViewModels
{
    public class RecipeDetailViewModel : BaseViewModel
    {
        private RecipeModel _selectedRecipe;

        public RecipeModel SelectedRecipe
        {
            get { return _selectedRecipe; }
            set
            {
                if (_selectedRecipe != value)
                {
                    _selectedRecipe = value;
                    OnPropertyChanged();
                }
            }
        }


        //private decimal _servings;

        //public decimal Servings
        //{
        //    get { return _servings; }
        //    set
        //    {
        //        if (_servings != value)
        //        {
        //            _servings = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}


        public List<string> InstructionsList { get; set; }
        public List<InstructionsData> InstructionsListWithIndex { get; set; }
        public RecipeDetailViewModel(RecipeModel selectedRecipe)
        {
            SelectedRecipe = selectedRecipe;
            //Servings = 1;
            InstructionsList = SelectedRecipe?.Instructions?.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            InstructionsListWithIndex = new List<InstructionsData>();
            foreach (string instruction in InstructionsList)
            {
                InstructionsData data = new InstructionsData();
                data.instruction = instruction;
                data.stepNo = InstructionsList.IndexOf(instruction) + 1;
                data.isDone = false;

                InstructionsListWithIndex.Add(data);
            }
        }

        public class InstructionsData
        {
            public string instruction { get; set; }
            public int stepNo { get; set; }
            public bool isDone { get; set; }

            
        }

        public ObservableCollection<IngredientModel> UpdateIngredientServings(decimal servings)
        {
            foreach (IngredientModel ing in SelectedRecipe.Ingredients)
            {
                decimal amount = decimal.Parse(ing.Amount);

                // Update amount based on serving size
                decimal newAmount = amount * servings;

                // Convert the result back to a string
                ing.Amount = newAmount.ToString();
            }

            return new ObservableCollection<IngredientModel>(SelectedRecipe.Ingredients);
        }

        //private decimal ParseFraction(string fractionString)
        //{
        //    string[] parts = fractionString.Split('/');

        //    if (parts.Length == 2 && decimal.TryParse(parts[0], out decimal numerator) && decimal.TryParse(parts[1], out decimal denominator))
        //    {
        //        if (denominator != 0)
        //        {
        //            return numerator / denominator;
        //        }
        //        else
        //        {
        //            throw new DivideByZeroException("Denominator cannot be zero.");
        //        }
        //    }
        //    else if (decimal.TryParse(fractionString, out decimal wholeNumber))
        //    {
        //        // If the string represents a whole number
        //        return wholeNumber;
        //    }
        //    else
        //    {
        //        return 0;
        //        //throw new FormatException($"Invalid fraction format: {fractionString}");
        //    }
        //}


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<string> GenerateShoppingList()
        {
            // Assuming Ingredients is a list of IngredientModel
            var shoppingList = new List<string>();

            foreach (var ingredient in SelectedRecipe.Ingredients)
            {
                //var formattedIngredient = $"{ingredient.amount} {ingredient.unit} {ingredient.name}";
                //shoppingList.Add(formattedIngredient);
            }

            return shoppingList;
        }
    }
}
