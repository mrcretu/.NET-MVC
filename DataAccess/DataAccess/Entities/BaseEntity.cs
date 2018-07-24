using System;

namespace DataAccess
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public BaseEntity()
        {
            Id = new Guid();
        }
    }
}
