using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HandleLet.Models
{
    public class Ingredients
    {
        private static int _nextId = 0;
        private int _id;
        private string _name;

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
        [Required(ErrorMessage = "Ingrediensen skal have et navn")]
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public Ingredients()
        {
            _id = 0;
            _name = "";
        }

        public Ingredients(string name)
        {
            NextId();
            name = _name;            
        }
    }
}
