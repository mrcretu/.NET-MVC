using System;
using System.Collections;
using System.Collections.Generic;
using DataAccess.Entities;

namespace DataAccess
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Post> Posts { get; set; }
    }
}
