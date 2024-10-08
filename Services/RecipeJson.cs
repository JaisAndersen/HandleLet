using HandleLet.Interfaces;
using HandleLet.Models;
using HandleLet.JsonHelpers;


namespace HandleLet.Services
{
    public class RecipeJson : IRecipe
    {
        string fileName = @"C:\Users\jaish\Source\Repos\HandleLet\Data\jsonRecipes.json";

        public void CreateRecipe(Recipe recipe)
        {
            List<Recipe> recipes = GetRecipe();
            recipes.Add(recipe);
            JsonFileWriterRecipe.WriteToJson(recipes, fileName);
        }

        public Recipe GetRecipeId(int id)
        {
            return null;
        }


        //public List<Item> FilterItems(string filter)
        //{
        //    List<Item> filteredList = new List<Item>();
        //    foreach (Item item in GetAllItems())
        //    {
        //        if (item.Name.Contains(filter, System.StringComparison.OrdinalIgnoreCase))
        //        {
        //            filteredList.Add(item);
        //        }
        //    }
        //    return filteredList;
        //}

        public List<Recipe> GetRecipe()
        {
            return JsonFileReaderRecipe.ReadJson(fileName);
        }

        public Recipe GetRecipe(string Title)
        {
            foreach (Recipe recipe in GetRecipe())
            {
                if (recipe.Title == Title) return recipe;
            }
            return new Recipe();
        }

        public void DeleteRecipe(string Title)
        {
            List<Recipe> Recipes = GetRecipe();
            foreach (Recipe recipe in Recipes.ToList())
            {
                if (recipe.Title == Title)
                    Recipes.Remove(recipe);
                JsonFileWriterRecipe.WriteToJson(Recipes, fileName);
            }
        }

        //public void UpdateItem(Item item)
        //{
        //    List<Item> Items = GetAllItems();
        //    foreach (Item Item in Items.ToList())
        //    {
        //        if (Item.Id == item.Id)
        //        {
        //            Item.Id = item.Id;
        //            Item.StorageType = item.StorageType;
        //            Item.Brand = item.Brand;
        //            Item.Name = item.Name;
        //            Item.Price = item.Price;
        //            Item.Quantity = item.Quantity;

        //            jsonFileWriterItem.WriteToJson(Items, fileName);
        //        }
        //    }
        //}
    }
}
