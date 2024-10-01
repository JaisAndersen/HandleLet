using HandleLet.Models;

namespace HandleLet.JsonHelpers
{
    public class JsonFileWriterIngredient
    {

        public static void WriteToJson(List<Ingredients> Ingredients, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(Ingredients, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
