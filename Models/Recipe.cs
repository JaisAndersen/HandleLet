namespace HandleLet.Models
{
    public class Recipe
    {


        public Recipe(string Title, string Description, int BusinessValue, int Priority, string StoryPoints, DateTime CreationDate)
        {
            this.Title = Title;
            this.Description = Description;
            
            

            Id = NextId++;
        }
    }
}
