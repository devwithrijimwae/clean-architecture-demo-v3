namespace Domain.Common
{
 public class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}
