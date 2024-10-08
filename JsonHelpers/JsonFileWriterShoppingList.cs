using HandleLet.Models;

namespace HandleLet.JsonHelpers
{
    public class JsonFileWriterShoppingList
    {
        public static void WriteToJson(List<ShoppingList> ShoppingLists, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(ShoppingLists, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
