namespace HandleLet.Models
{
    public class Recipe
    {
        private _title
        
        public string _Description { get; set; }


        public Recipe(string Title, string Description)
        {
            this.Title = Title;
            this.Description = Description;
            
            

            Id = NextId++;
        }



        public string _title { get; set; }
        public string _Description { get; set; }
    }
}
