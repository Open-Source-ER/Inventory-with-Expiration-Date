
using InventoryApp.Generics;
using SQLite;

namespace InventoryApp.Objects
{
    public class CategoryAlert : Table
    {
        [PrimaryKey, AutoIncrement]
        public override int Id { get; protected set; }

        public int CategoryId { get; set; }
        public int DayPeriod { get; set; }
        public string AlertColor { get; set; }
        public bool AlertFlag { get; set; }

        public CategoryAlert()
        {
            Id = 0;
        }

        public CategoryAlert(int catId, int days, string color, bool flag)
        {
            Id = 0;

            CategoryId = catId;
            DayPeriod = days;
            AlertColor = color;
            AlertFlag = flag;
        }
    }
}
