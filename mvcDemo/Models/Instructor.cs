namespace mvcDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Instructor
    {
        public int InstructorId { get; set; }

        [Required]
        public string InstructorName { get; set; }

        [Required]
        public string InstructorImg { get; set; }

        public string InstructorPosition { get; set; }

        public string Tw { get; set; }

        public string Fb { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
    }
}
