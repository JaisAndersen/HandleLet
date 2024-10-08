using HandleLet.Models;
using Newtonsoft.Json;

namespace HandleLet.JsonHelpers
{
    public class JsonFileReaderShoppingList
    {
        public static List<ShoppingList> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            using (var jsonFileReader = File.OpenText(JsonFileName))
            { return JsonConvert.DeserializeObject<List<ShoppingList>>(jsonString); }
        }
    }
}
