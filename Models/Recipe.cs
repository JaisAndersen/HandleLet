namespace HandleLet.Models
{
    public class Recipe
    {

        private static int NextId = 1;

        public Recipe(string Title, string Description)
        {
            this.Title = Title;
            this.Description = Description;
            
            

            Id = NextId++;
        }


        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
