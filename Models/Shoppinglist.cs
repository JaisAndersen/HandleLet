using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HandleLet.Models
{
    public class ShoppingList
    {
        private static int _nextId = 0;
        private int _id;
        private string _name;
        private Ingredients _ingredients;

        void NextId()
        {
            _nextId++;
            _id = _nextId;
        }

        [BindProperty]
        [Display(Name = "Id")]
        [Range(minimum: 0, maximum: 1000)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Display(Name = "Navn")]
        [Required(ErrorMessage = "ShoppingList skal have et navn")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Ingredients Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }

        public ShoppingList()
        {
            _id = 0;
            _name = "";
            _ingredients = null;
        }

        public ShoppingList(string name, Ingredients ingredients)
        {
            NextId();
            _name = name;
            _ingredients = ingredients;
        }
    }
}
