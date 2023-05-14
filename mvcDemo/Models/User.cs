namespace mvcDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public Guid UserId { get; set; }

      
        public string UserName { get; set; }

       
        public string Password { get; set; }

        public string Mobile { get; set; }

       
        public string Email { get; set; }

        
        public string Address { get; set; }

        public string UserImg { get; set; }

        public int Gender { get; set; }

        public Guid RoleId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public virtual Role Role { get; set; }
    }
}
