namespace DashBoard.Entities
{
    public class T_Card:BaseEntity
    {
        public int Id_Teacher { get; set; }

        public int Id_Book { get; set; }

        public int Id_Lib { get; set; }

        public DateTime DateOut { get; set; }

        public DateTime? DateIn { get; set; }

    }
}
