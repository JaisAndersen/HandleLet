using HandleLet.Models;
using Newtonsoft.Json;

namespace HandleLet.JsonHelpers
{
    public class JsonFileReaderRecipe
    {

        public static List<Recipe> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            using (var jsonFileReader = File.OpenText(JsonFileName))
            { return JsonConvert.DeserializeObject<List<Recipe>>(jsonString); }
        }
    }
}
