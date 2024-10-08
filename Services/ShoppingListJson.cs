using HandleLet.JsonHelpers;
using HandleLet.Models;

namespace HandleLet.Services
{
    public class ShoppingListJson
    {
        string fileName = @"C:\Users\jaish\Source\Repos\HandleLet\Data\jsonShoppingList.json";

        public void CreateShoppingList(ShoppingList shoppingList)
        {
            List<ShoppingList> shoppingLists = GetShoppingList();
            shoppingLists.Add(shoppingList);
            JsonFileWriterShoppingList.WriteToJson(shoppingLists, fileName);
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

        public List<ShoppingList> GetShoppingList()
        {
            return JsonFileReaderShoppingList.ReadJson(fileName);
        }

        public ShoppingList GetShoppingList(string Name)
        {
            foreach (ShoppingList shoppingList in GetShoppingList())
            {
                if (shoppingList.Name == Name) return shoppingList;
            }
            return new ShoppingList();
        }

        public void DeleteShoppingList(string Name)
        {
            List<ShoppingList> ShoppingLists = GetShoppingList();
            foreach (ShoppingList shoppingList in ShoppingLists.ToList())
            {
                if (shoppingList.Name == Name)
                    ShoppingLists.Remove(shoppingList);
                JsonFileWriterShoppingList.WriteToJson(ShoppingLists, fileName);
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
