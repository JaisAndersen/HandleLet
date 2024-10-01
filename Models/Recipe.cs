using System.Xml.Linq;

namespace HandleLet.Models
{
    public class Recipe
    {
        private string _description;
        private string _title;
        private static int NextId = 1;
        public Ingredients Ingredients { get; set; }




        public Recipe()
        {
            _title = Title;
            _description = Description;
            
            

            id = NextId++;
        }


        public int id { get; set; }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
