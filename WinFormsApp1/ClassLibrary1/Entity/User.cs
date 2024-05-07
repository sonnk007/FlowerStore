using System;
using System.Collections.Generic;

namespace DataAccess.Entity
{
    public partial class User
    {
        public int Uid { get; set; }
        public string Uname { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string Address { get; set; } = null!;
        public bool Gender { get; set; }
    }
}
