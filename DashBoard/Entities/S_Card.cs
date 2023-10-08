namespace DashBoard.Entities
{
    public class S_Card:BaseEntity
    {
        public int Id_Student { get; set; }

        public int Id_Book { get; set; }

        public int Id_Lib { get; set; }

        public DateTime DateOut { get; set; }

        public DateTime DateIn { get; set; }
    }
}
