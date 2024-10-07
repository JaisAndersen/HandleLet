using HandleLet.Models;

namespace HandleLet.Interfaces
{
    public interface IShoppingList
    {
        public List<ShoppingList> GetShoppingList();

        public ShoppingList GetShoppingList(string Name);

        public void DeleteShoppingList(string Name);

        public void CreateShoppingList(ShoppingList shoppingList);
    }
}
