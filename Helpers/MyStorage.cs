using System.Xml.Serialization;
//using UIKit;

namespace FoodRecipe
{
    internal class MyStorage
    {
        internal static async Task<T> ReadEmbeddedXML<T>(string file)
        {
            string data = string.Empty;
            try
            {
                using Stream stream = await FileSystem.Current.OpenAppPackageFileAsync(file);
                using (TextReader reader = new StreamReader(stream))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(reader);
                };

            }
            catch (Exception x)
            {
                await Shell.Current.DisplayAlert("Error", $"DATA: {data}\n{x}", "ok");
                return default(T);
            }
        }
    }
}










//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;
//using System.Xml.Linq;
//using System.Xml.Serialization;

//namespace FoodRecipe.Helpers
//{
//    public static class MyStorage
//    {

//        public static async Task<List<RecipeModel>> ReadDataAsync()
//        {
//            List<RecipeModel> recipes = new List<RecipeModel>();

//            var stream = await FileSystem.OpenAppPackageFileAsync("recipelist.xml");

//            var reader1 = new StreamReader(stream);
//            var xml = await reader1.ReadToEndAsync();

//            var serializer = new XmlSerializer(typeof(List<RecipeModel>));
//             //List < RecipeModel > result;

//            using (TextReader reader = new StringReader(xml))
//            {
//                recipes = (List<RecipeModel>)serializer.Deserialize(reader);
//                Debug.WriteLine(serializer.Deserialize(reader));
//            }


//            return recipes;

//        }

//    }
//}
