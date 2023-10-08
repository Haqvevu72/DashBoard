namespace DashBoard.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public BaseEntity()
        {
            Created = DateTime.Now;
        }
    }
}
