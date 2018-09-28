using SQLite;
namespace FitnessWarrors.Model
{
    public class Session
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Food { get; set; }
        public string Calories { get; set; }
        public Session() { }
        public Session(string Food, string Calories)
        {
            this.Food = Food;
            this.Calories = Calories;
        }
    }
}