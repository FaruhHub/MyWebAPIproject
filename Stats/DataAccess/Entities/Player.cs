namespace Stats.DataAccess.Entities {
    public class Player : EntityBase {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Team Team { get; set; }
    }
}