namespace DashBoard.Entities
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id_Group { get; set; }

        public int Term { get; set; }
    }
}
