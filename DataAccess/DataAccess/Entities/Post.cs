using System;

namespace DataAccess.Entities
{
    public class Post : BaseEntity
    {
        public DateTime AddedDate { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
