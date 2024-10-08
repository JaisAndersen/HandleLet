using HandleLet.Models;

namespace HandleLet.JsonHelpers
{
    public class JsonFileWriterRecipe
    {
        public static void WriteToJson(List<Recipe> Recipes, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(Recipes, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
