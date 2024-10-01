using HandleLet.Models;


namespace HandleLet.JsonHelpers
{
    public class JsonFileReaderIngredient
    {
        public static List<Ingredients> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            using (var jsonFileReader = File.OpenText(JsonFileName))
            { return JsonConvert.DeserializeObject<List<Ingredients>>(jsonString); }
        }
    }
}
