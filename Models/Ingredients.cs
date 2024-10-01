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
    }
}
