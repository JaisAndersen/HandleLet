namespace HandleLet.Models
{
    public class Recipe
    {
        
        private static int NextId = 1;
        public Ingredients Ingredients { get; set; }

        public Recipe(string Title, string Description)
        {
            _title = Title;
            _description = Description;
            
            

            Id = NextId++;
        }


        public int Id { get; set; }
        public string _title { get; set; }
        public string _description { get; set; }
    }
}
