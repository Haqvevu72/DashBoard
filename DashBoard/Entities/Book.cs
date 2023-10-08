namespace DashBoard.Entities
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }

        public  int Pages { get; set; }

        public DateTime YearPress { get; set; }

        public int Id_Theme { get; set; }

        public  int  Id_Category { get; set; }

        public int Id_Author { get; set; }

        public int Id_Press { get; set; }

        public string Comment { get; set; }

        public int Quantity { get; set; }
    }
}
