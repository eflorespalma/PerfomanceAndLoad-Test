using Course.Entity.Base;

namespace Course.Entity
{
    public class Gift : IEntity
    {
        public int Id { get; set; }
        public string Genere { get; set; }
        public double Price { get; set; }
    }
}
