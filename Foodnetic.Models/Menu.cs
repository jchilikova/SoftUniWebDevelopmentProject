namespace Foodnetic.Models
{
    public class Menu
    {
        public string Id { get; set; }

        public Recipe Breakfast { get; set; }

        public Recipe Lunch { get; set; }

        public Recipe Dinner { get; set; }

        public Recipe Dessert { get; set; }
    }
}
