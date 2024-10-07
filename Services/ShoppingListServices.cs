using HandleLet.Interfaces;
using HandleLet.Models;
namespace HandleLet.Services
{
    public class ShoppingListServices : IShoppingList
    {
        public List<ShoppingList> ShoppingList;

        public ShoppingListServices()
        {
            ShoppingList = new List<ShoppingList>();
        }

        public List<ShoppingList> GetShoppingList()
        {
            return ShoppingList;
        }

        public ShoppingList GetShoppingList(string Name)
        {
            foreach (ShoppingList shoppingList in ShoppingList)
            {
                if (shoppingList.Name == Name)
                return shoppingList;
            }

            return null;
        }
        public void DeleteShoppingList(string Name)
        {
            foreach (ShoppingList shoppingList in ShoppingList.ToList())
            {
                if (shoppingList.Name == Name)
                    ShoppingList.Remove(shoppingList);
            }
        }


        public void CreateShoppingList(ShoppingList shoppingList)
        {

            ShoppingList.Add(shoppingList);

        }
    }
}

